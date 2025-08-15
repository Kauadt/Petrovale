import React, { useState, useEffect } from "react";
import { Text, View, TouchableOpacity, ScrollView, Modal, SafeAreaView, TextInput } from "react-native";
import { Ionicons } from '@expo/vector-icons';
import { styles } from './styles';
import * as Animatable from 'react-native-animatable';
import axios from "axios";
import apiUrl from "../apiConfig";


export const Fuel = ({ closeModalControls }) => {

    useEffect(() => {
        listFuelData()
    }, [])

    useEffect(() => {
        if (selectedFuel) {
            calculatePrice()
        }
    }, [selectedFuel, priceFuel])


    const [listFuel, setListFuel] = useState([]);
    const [search, setSearch] = useState('');


    async function listFuelData() {
        const res = await axios.get(apiUrl + 'listar.php?list=fuel&busca=' + search);
        setListFuel(res.data.result);
    }

    const [liters, setLiters] = useState('');
    const [priceFuel, setPriceFuel] = useState(0);
    const [nameFuel, setNameFuel] = useState('Combustível');
    const [discount, setDiscount] = useState(0)
    const [openSimulation, setOpenSimulation] = useState(false);
    const [selectedFuel, setSelectedFuel] = useState(null);

    function calculatePrice() {
        let grossValue = selectedFuel.price;
        let discount = selectedFuel.price * (selectedFuel.discount / 100);
        let netValue = grossValue - discount;
        let totalPrice = priceFuel / netValue;
        setLiters(totalPrice)
    }

    return <>
        <ScrollView>
            <View style={styles.container}>
                <View style={styles.navTop}>
                    <TouchableOpacity style={styles.btnBack}
                        onPress={() => closeModalControls('fuel')}
                    >
                        <Ionicons name='chevron-back-outline' color={'#fff'} size={35}></Ionicons>
                    </TouchableOpacity>
                    <Text style={styles.navTopTitle}>Combustível</Text>
                </View>


                <View style={styles.containerListFuel}>
                    {listFuel.map((fuel) => (
                        <View style={styles.cardFuel} key={fuel.idService}>
                            <Text style={styles.nameFuel}>{fuel.nameService}</Text>
                            <View style={{ flexDirection: 'row', justifyContent: 'space-between' }}>
                                <View style={styles.containerPrice}>
                                    <Text style={styles.priceFuel}>R$ {fuel.price.replace('.', ',')}/L</Text>
                                    <Text style={styles.discountFuel}>{(parseFloat(fuel.discount)).toFixed(0)}% OFF</Text>


                                </View>
                                <TouchableOpacity style={styles.btnFuel}
                                    onPress={() => {
                                        setSelectedFuel(fuel);
                                        setNameFuel(fuel.nameService)
                                        setOpenSimulation(true);
                                    }}
                                >
                                    <Text style={styles.btnFuelText}>Simular Preços</Text>
                                </TouchableOpacity>
                            </View>
                        </View>
                    ))}
                </View>
            </View>
        </ScrollView>
        <Modal
            visible={openSimulation}
            transparent={true}
            animationType='slide'
            style={{ flex: 1 }}
        >
            <SafeAreaView
                style={{ flex: 1 }}
            >
                <Animatable.View
                    style={{ flex: 1 }}
                >
                    <View style={styles.containerSimulation}>

                        <TouchableOpacity
                            style={{
                                position: 'absolute',
                                top: 20,
                                right: 40,
                                paddingVertical: 10,
                            }}
                            onPress={() => setOpenSimulation(false)}
                        >
                            <Text style={{ color: '#6F6F6F', fontSize: 16, fontWeight: '600' }}>Fechar</Text>
                        </TouchableOpacity>
                        <TouchableOpacity
                            style={{
                                position: 'absolute',
                                top: 20,
                                left: 40
                            }}
                            onPress={() => calculatePrice()}
                        >
                            <Text style={{
                                color: '#fff',
                                paddingHorizontal: 20,
                                paddingVertical: 10,
                                backgroundColor: '#258D5C',
                                fontSize: 16,
                                fontWeight: '600',
                                borderRadius: 5
                            }}
                            >Calcular</Text>
                        </TouchableOpacity>

                        <View>
                            <Text style={styles.labelInput}>
                                {nameFuel} (R$)
                            </Text>

                            <TextInput
                                style={styles.inputSimulation}
                                value={priceFuel.toString()}
                                keyboardType="numeric"
                                onChangeText={(price) => {
                                    setPriceFuel(price)
                                }}
                            ></TextInput>
                        </View>
                        <View style={styles.iconSwap}>
                            <Ionicons name="swap-horizontal-outline" color={'#6F6F6F'} size={30}></Ionicons>
                        </View>
                        <View>
                            <Text style={styles.labelInput}>
                                L
                            </Text>
                            <TextInput
                                style={styles.inputSimulation}
                                value={liters.toString()}
                                keyboardType="numeric"
                                editable={false}
                            ></TextInput>
                        </View>
                    </View>
                </Animatable.View>
            </SafeAreaView>
        </Modal>
    </>
}
