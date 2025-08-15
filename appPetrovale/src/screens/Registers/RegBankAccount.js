import React, { useState } from "react";
import { Text, View, TextInput, TouchableOpacity, Image, Switch, ScrollView, Alert} from 'react-native';
import { styles } from './styles';
import { Ionicons } from '@expo/vector-icons';
import axios from "axios";
import apiUrl from "../apiConfig";


export const RegBankAccount = ({ closeRegBankAccount, data, closeRegisters }) => {

    const [numBank, setNumBank] = useState('');
    const [agency, setAgency] = useState('');
    const [currentAcc, setCurrentAcc] = useState('');
    const [isAutoDebit, setIsAutoDebit] = useState(false);

    const dataAdd = data()
    const { nome, email, senha, cpf, telefone, numAdd, street, bairro, city, state } = dataAdd
    const insertAutoDebit = () => { return isAutoDebit ? 'Ativo' : 'Inativo' }


    const add = async () => {
        const obj = {
            nome,
            email,
            senha,
            cpf,
            telefone,
            numAdd,
            street,
            bairro,
            city,
            state,
            numBank,
            agency,
            currentAcc,
            autoDebitStatus: insertAutoDebit(),
        };

        try {
            const res = await axios.post(apiUrl + 'add.php', obj, {
                headers: {
                    'Content-Type': 'application/json',
                },
            });

            if (res.data.success === true) {
                Alert.alert(
                    "Cadastro",
                    "Cadastro realizado com sucesso, faça o seu login",
                    [
                        { text: "OK", onPress: () => closeRegisters() },
                    ],
                    { cancelable: true }
                );
            }

            if (res.data.success === 'Email já Cadastrado!') {
                alert('Email já cadastrado');
            }
        } catch (error) {
            console.error('Erro na requisição:', error);
        }
    };


    return <>
        <View style={styles.container}>
            <ScrollView>
                <View style={styles.navTop}>
                    <TouchableOpacity
                        style={styles.btnBack}
                        onPress={() => closeRegBankAccount()}
                    >
                        <Ionicons name='chevron-back-outline' color={'#fff'} size={30}></Ionicons>
                    </TouchableOpacity>
                </View>

                <View style={styles.containerLogo}>
                    <Image source={require('../../../assets/login_green_logo.png')}></Image>
                </View>

                <View style={styles.containerForm}>
                    <Text style={styles.registerTitle}>Conta Bancária</Text>
                    <Text style={styles.registerSubTitle}>Insira informações sobre a sua conta bancária</Text>

                    <View style={styles.form}>
                        <Text style={styles.formRegisterLabel}>Número do banco </Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o número do banco"
                            onChangeText={(numBank) => setNumBank(numBank)}
                            value={numBank}
                        ></TextInput>
                        <Text style={styles.formRegisterLabel}>Agência </Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o número da agência"
                            onChangeText={(agency) => setAgency(agency)}
                            value={agency}
                        ></TextInput>
                        <Text style={styles.formRegisterLabel}>Conta Corrente </Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o número da conta corrente"
                            onChangeText={(currentAcc) => setCurrentAcc(currentAcc)}
                            value={currentAcc}
                        ></TextInput>


                        <View style={styles.containerAutoDebit}>
                            <Text style={styles.autoDebitText}>Débito Automático</Text>
                            <View style={styles.containerSwitch}>
                                <Switch
                                    value={isAutoDebit}
                                    onValueChange={(isAutoDebit) => {
                                        setIsAutoDebit(isAutoDebit);
                                        insertAutoDebit()
                                    }}
                                    trackColor={{ false: '#767577', true: '#005A40' }}
                                    thumbColor={isAutoDebit ? '#f4f3f4' : '#f4f3f4'}
                                ></Switch>
                            </View>
                        </View>


                        <TouchableOpacity
                            style={styles.formRegisterBtn}
                            onPress={add}
                        >
                            <Text style={styles.formRegisterBtnText}>Cadastrar-se</Text>
                        </TouchableOpacity>
                    </View>
                </View>
            </ScrollView>
        </View>
    </>
}
