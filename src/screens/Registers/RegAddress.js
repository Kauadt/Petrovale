import React, { useState } from "react";
import { Text, View, TextInput, TouchableOpacity, Image, ScrollView, Modal, SafeAreaView, Alert } from 'react-native';
import * as Animatable from 'react-native-animatable';
import { StatusBar } from "expo-status-bar";
import { styles } from './styles';
import { Ionicons } from '@expo/vector-icons';
import { RegBankAccount } from "./RegBankAccount";


export const RegAddress = ({ closeRegAddress, data, closeRegisters }) => {

    const dataLogin = data()
    const { nome, email, senha } = dataLogin

    sendDataAdd = () => {
        return { nome, email, senha, cpf, telefone, numAdd, street, bairro, city, state }
    }

    const [openRegBankAccount, setOpenRegBankAccount] = useState(false);

    const closeRegBankAccount = () => {
        setOpenRegBankAccount(false);
    }

    const dataVerification = () => {
        cpf === '' ||
            telefone === '' ||
            numAdd === '' ||
            street === '' ||
            bairro === '' ||
            city === '' ||
            state === '' ?
            dataVerificationMsg() :

            (setOpenRegBankAccount(true))
    }

    const dataVerificationMsg = () =>
        Alert.alert(
            "Erro ao continuar",
            "Preencha todos os campos",
            [
                { text: "OK" }
            ],
            { cancelable: true }
        );

    const [cpf, setCpf] = useState('');
    const [telefone, setTelefone] = useState('');
    const [numAdd, setNumAdd] = useState('');
    const [street, setStreet] = useState('');
    const [bairro, setBairro] = useState('');
    const [city, setCity] = useState('');
    const [state, setState] = useState('');

    return <>
        <Modal
            visible={openRegBankAccount}
            transparent={false}
            animationType='slide'
            style={{ flex: 1 }}
        >
            <StatusBar hidden></StatusBar>
            <SafeAreaView style={{ flex: 1 }}>
                <Animatable.View style={{ flex: 1 }}>
                    <RegBankAccount closeRegBankAccount={closeRegBankAccount} data={sendDataAdd} closeRegisters={closeRegisters}></RegBankAccount>
                </Animatable.View>
            </SafeAreaView>
        </Modal>

        <View style={styles.container}>
            <ScrollView>
                <View style={styles.navTop}>
                    <TouchableOpacity style={styles.btnBack}
                        onPress={() => closeRegAddress()}
                    >
                        <Ionicons name='chevron-back-outline' color={'#fff'} size={30}></Ionicons>
                    </TouchableOpacity>
                </View>

                <View style={styles.containerLogo}>
                    <Image source={require('../../../assets/login_green_logo.png')}></Image>
                </View>

                <View style={styles.containerForm}>
                    <Text style={styles.registerTitle}>Cadastro</Text>
                    <Text style={styles.registerSubTitle}>Insira mais algumas informações</Text>

                    <View style={styles.form}>
                        <Text style={styles.formRegisterLabel}>CPF</Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o seu CPF"
                            onChangeText={(cpf) => setCpf(cpf)}
                            value={cpf}
                            keyboardType="numeric"
                        ></TextInput>
                        <Text style={styles.formRegisterLabel}>Telefone</Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o seu telefone"
                            onChangeText={(telefone) => setTelefone(telefone)}
                            value={telefone}
                            keyboardType="numeric"
                        ></TextInput>

                        <View style={styles.containerTitle}>
                            <Text style={styles.registerTitle}>Endereço</Text>
                            <Text style={styles.registerSubTitle}>Insira informações sobre o seu enderço</Text>
                        </View>

                        <Text style={styles.formRegisterLabel}>Número</Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o número"
                            onChangeText={(numAdd) => setNumAdd(numAdd)}
                            value={numAdd}
                            keyboardType="numeric"
                        ></TextInput>

                        <Text style={styles.formRegisterLabel}>Rua</Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite a rua"
                            onChangeText={(street) => setStreet(street)}
                            value={street}
                        ></TextInput>

                        <Text style={styles.formRegisterLabel}>Bairro</Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o bairro"
                            onChangeText={(bairro) => setBairro(bairro)}
                            value={bairro}
                        ></TextInput>

                        <Text style={styles.formRegisterLabel}>Cidade</Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite a cidade"
                            onChangeText={(city) => setCity(city)}
                            value={city}
                        ></TextInput>

                        <Text style={styles.formRegisterLabel}>Estado</Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o estado"
                            onChangeText={(state) => setState(state)}
                            value={state}
                        ></TextInput>

                        <TouchableOpacity
                            style={styles.formRegisterBtn}
                            onPress={() => dataVerification()}
                        >
                            <Text style={styles.formRegisterBtnText}>Continuar</Text>
                        </TouchableOpacity>
                    </View>
                </View>
            </ScrollView>
        </View>
    </>
}
