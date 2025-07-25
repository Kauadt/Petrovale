import React, { useState } from "react";
import { Text, View, TextInput, TouchableOpacity, Image, Modal, SafeAreaView, ScrollView, Alert } from 'react-native';
import { styles } from './styles';
import { Ionicons } from '@expo/vector-icons';
import * as Animatable from 'react-native-animatable';
import { StatusBar } from "expo-status-bar";
import { RegAddress } from "./RegAddress";


export const RegLogin = ({ closeRegLogin }) => {

    const [openRegAddress, setOpenAddress] = useState(false);
    const [nome, setNome] = useState('');
    const [email, setEmail] = useState('');
    const [senha, setSenha] = useState('');
    const dataVerification = () => {
        (nome === '' || email === '' || senha === '') ?
            dataVerificationMsg() :
            (
                setOpenAddress(true)
            );
    }

    const closeRegisters = () => {
        closeRegLogin()
    }


    const sendData = () => {
        return {nome: nome, email: email, senha: senha}
    }


    const closeRegAddress = () => {
        setOpenAddress(false);
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

    return <>

        <Modal
            visible={openRegAddress}
            transparent={false}
            animationType='slide'
            style={{ flex: 1 }}
        >
            <StatusBar hidden></StatusBar>
            <SafeAreaView style={{ flex: 1 }}>
                <Animatable.View style={{ flex: 1 }}>
                    <RegAddress closeRegAddress={closeRegAddress} closeRegisters={closeRegisters} data={sendData}></RegAddress>
                </Animatable.View>
            </SafeAreaView>
        </Modal>

        <ScrollView>
            <View style={styles.container}>
                <View style={styles.navTop}>
                    <TouchableOpacity style={styles.btnBack}
                        onPress={() => closeRegLogin()}
                    >
                        <Ionicons name='chevron-back-outline' color={'#fff'} size={30}></Ionicons>
                    </TouchableOpacity>
                </View>

                <View style={styles.containerLogo}>
                    <Image source={require('../../../assets/login_green_logo.png')}></Image>
                </View>

                <View style={styles.containerForm}>
                    <Text style={styles.registerTitle}>Cadastro</Text>
                    <Text style={styles.registerSubTitle}>Crie uma conta para continuar</Text>

                    <View style={styles.form}>
                        <Text style={styles.formRegisterLabel}>Nome </Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o seu nome"
                            onChangeText={(nome) => setNome(nome)}
                            value={nome}
                        ></TextInput>
                        <Text style={styles.formRegisterLabel}>E-mail </Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite o seu e-mail"
                            onChangeText={(email) => setEmail(email)}
                            value={email}
                        ></TextInput>
                        <Text style={styles.formRegisterLabel}>Senha </Text>
                        <TextInput
                            style={styles.formRegisterInput}
                            placeholder="Digite a sua senha"
                            onChangeText={(senha) => setSenha(senha)}
                            secureTextEntry
                            value={senha}
                        ></TextInput>

                        <TouchableOpacity
                            style={styles.formRegisterBtn}
                            onPress={dataVerification}
                        >
                            <Text
                                style={styles.formRegisterBtnText}
                            >Continuar</Text>
                        </TouchableOpacity>


                    </View>
                </View>
            </View>
        </ScrollView>
    </>
}
