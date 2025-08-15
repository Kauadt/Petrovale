import React, { useState, useEffect } from "react";
import { styles } from "./styles";
import { Text, View, Image, TouchableOpacity, Alert } from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import { format, utcToZonedTime } from 'date-fns-tz';
import axios from "axios";
import apiUrl from "../apiConfig";

export const Product = ({ showItemsHome, closeProduct, clientsDetails }) => {

    itemsHome = showItemsHome();
    userData = clientsDetails();

    const [formattedDate, setFormattedDate] = useState('');



    const getFormattedDate = () => {
        const brazilTimeZone = 'America/Sao_Paulo';
        const currentDate = new Date();
        const currentDateInBrazil = utcToZonedTime(currentDate, brazilTimeZone);

        return format(currentDateInBrazil, 'yyyyMMdd', { timeZone: brazilTimeZone });
    };


    const makePayments = () => {
        if (userData.autoDebit == 'Ativo') {
            Alert.alert(
                "Comprar Produto",
                "Você deseja comprar "+ itemsHome[0] +" ?",
                [
                    { text: "Sim", onPress: () => add() },
                    {
                        text: "Não",
                        onPress: () => console.log("Cancel Pressed"),
                        style: 'cancel'
                    },
                ],
                { cancelable: true }
            );
        }
    }


    const add = async () => {
        console.log('Iniciando operação de adição de produto.');

        const obj = {
            valor: itemsHome[5],
            data: getFormattedDate(),
            quantidade: 1,
            idPosto: 1,
            idProduto: itemsHome[1],
            idCliente: userData.id,
        };

        try {
            const res = await axios.post(apiUrl + 'addProduto.php', obj, {
                headers: {
                    'Content-Type': 'application/json',
                },
            });


            if (res.data.success === true) {
                alert('Agendamento realizado com sucesso!');
            }
        } catch (error) {
            console.error('Erro na requisição:', error);
        }
    };


    return <>
        <View style={styles.container}>
            <View style={styles.navTopStore}>
                <TouchableOpacity style={styles.btnBack}
                    onPress={() => closeProduct()}
                >
                    <Ionicons name='chevron-back-outline' color={'#fff'} size={28}></Ionicons>
                </TouchableOpacity>
            </View>
            <View style={styles.containerImageProduct}>
                <Ionicons name="image-outline" color={'#000'} size={90}></Ionicons>
            </View>
            <View style={styles.containerInfoProduct}>
                <Text style={styles.nameProduct}>{itemsHome[0]}</Text>
                <Text style={styles.descriptionProduct}>{itemsHome[2]}</Text>
            </View>

            <View style={styles.navbar}>
                <Text style={styles.priceProductText}>R$ {itemsHome[5]}</Text>
                <View style={styles.buttonsProduct}>
                    <TouchableOpacity
                        style={styles.btnMonthlyProduct}
                    >
                        <Text style={styles.btnMonthlyText}>Conta Mensal</Text>
                    </TouchableOpacity>
                    <TouchableOpacity
                        style={styles.btnBuyProduct}
                        onPress={() => {makePayments()}}
                    >
                        <Text style={styles.btnBuyText}>Comprar</Text>
                    </TouchableOpacity>
                </View>
            </View>
        </View>
    </>
}   