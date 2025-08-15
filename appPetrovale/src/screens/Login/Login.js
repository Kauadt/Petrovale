import React, { useState, useEffect } from "react";
import { Text, View, TextInput, TouchableOpacity, Image, Modal, SafeAreaView, Alert } from 'react-native';
import { styles } from './styles';
import * as Animatable from 'react-native-animatable';
import { StatusBar } from "expo-status-bar";
import { RegLogin } from "../Registers/RegLogin";
import axios from "axios";
import apiUrl from "../apiConfig";

export const Login = ({ closeLogin, getClientDetails }) => {


    const [search, setSearch] = useState('');
    const [userData, setUserData] = useState('');

    useEffect(() => {

        if (userData) {
            listProfileData(userData[0].id_cliente)
        }

    }, [userData]);

    const login = async () => {
        const obj = { email, senha };
        const res = await axios.post(apiUrl + 'login.php', obj);

        if (res.data.success === "Dados Incorretos!") {
            alert('Dados Incorretos');
        } else {
            setUserData(res.data.data);
            closeLogin()
        }
    };

    const closeRegLogin = () => {
        setOpenRegLogin(false);
    }

    const [profileData, setProfileData] = useState([]);
    async function listProfileData(dt) {
        const res = await axios.get(apiUrl + 'listarPerfil.php?idCliente=' + dt + '&busca=' + search);
        setProfileData(res.data.result)
        getClientDetails(res.data.result)
    }



    const [openRegLogin, setOpenRegLogin] = useState(false);
    const [email, setEmail] = useState('');
    const [senha, setSenha] = useState('');



    return <>
        <View style={styles.container}>

            <Modal
                visible={openRegLogin}
                transparent={false}
                animationType='slide'
                style={{ flex: 1 }}
            >
                <StatusBar hidden></StatusBar>
                <SafeAreaView style={{ flex: 1 }}>
                    <Animatable.View style={{ flex: 1 }}>
                        <RegLogin closeRegLogin={closeRegLogin}></RegLogin>
                    </Animatable.View>
                </SafeAreaView>
            </Modal>


            <View style={styles.containerLogo}>
                <Image source={require('../../../assets/login_green_logo.png')}></Image>
            </View>

            <View style={styles.containerForm}>
                <Text style={styles.loginTitle}>Login</Text>
                <Text style={styles.loginSubTitle}>Faça o seu login para continuar</Text>

                <View style={styles.form}>
                    <Text style={styles.formLoginLabel}>E-mail</Text>
                    <TextInput
                        style={styles.formLoginInput}
                        placeholder="Digite o seu e-mail"
                        onChangeText={(email) => setEmail(email)}
                        value={email}
                    ></TextInput>
                    <Text style={styles.formLoginLabel}>Senha</Text>
                    <TextInput
                        style={styles.formLoginInput}
                        placeholder="Digite a sua senha"
                        onChangeText={(senha) => setSenha(senha)}
                        value={senha}
                        secureTextEntry
                    ></TextInput>

                    <TouchableOpacity
                        style={styles.formLoginBtn}
                        onPress={() => {
                            login();
                            getClientDetails(profileData)
                        }}
                    >
                        <Text style={styles.formLoginBtnText}
                        >Entrar</Text>
                    </TouchableOpacity>

                    <Text style={styles.textRegister}>Não possui uma conta?</Text>
                    <TouchableOpacity
                        style={styles.btnRegister}
                        onPress={() => setOpenRegLogin(true)}
                    >
                        <Text style={styles.btnRegisterText}>Registre-se</Text>
                    </TouchableOpacity>

                </View>
            </View>





        </View>
    </>
}
