import React, { useState } from "react";
import { Text, View, TouchableOpacity, ScrollView, Modal, SafeAreaView, DevSettings, Alert } from 'react-native';
import * as Animatable from 'react-native-animatable';
import { StatusBar } from "expo-status-bar";
import { styles } from './styles';
import { Ionicons } from '@expo/vector-icons';
import { UpdateProfile } from "./UpdateProfile";
import axios from "axios";
import apiUrl from "../apiConfig";

export const Profile = ({ closeModalControls, clientsDetails }) => {

    clientsData = clientsDetails();

    const [isCloseModalUpdate, setIsCloseModalUpdate] = useState(false);

    const closeModal = () => {
        setIsCloseModalUpdate(false)
    }

    const sendClientsData = () => {
        return clientsData;
    }



    function exitAccount() {
        Alert.alert(
            "Sair",
            "Deseja sair da conta?",
            [
                {
                    text: "Não",
                    onPress: () => console.log("Cancel Pressed"),
                    style: 'cancel'
                },
                { text: "Sim", onPress: () => DevSettings.reload() }
            ],
            { cancelable: true }
        );
    }

    async function deleteAccount(id) {
        const res = await axios.get(apiUrl + 'excluir.php?id=' + id);
    }

    function deleteConfirmation() {
        Alert.alert(
            "Excluir Conta",
            "Deseja excluir a sua conta?",
            [
                {
                    text: "Não",
                    onPress: () => console.log("Cancel Pressed"),
                    style: 'cancel'
                },
                { text: "Sim", onPress: () => {deleteAccount(clientsData.id); DevSettings.reload()} }
            ],
            { cancelable: true }
        );
    }


    return <>
        <Modal
            visible={isCloseModalUpdate}
            transparent={false}
            animationType='slide'
            style={{ flex: 1 }}
        >
            <StatusBar hidden></StatusBar>
            <SafeAreaView style={{ flex: 1 }}>
                <Animatable.View style={{ flex: 1 }}>
                    <UpdateProfile closeModal={closeModal} clientsDetails={sendClientsData}></UpdateProfile>
                </Animatable.View>
            </SafeAreaView>
        </Modal>

        <View style={styles.container}>
            <StatusBar translucent />
            <ScrollView>
                <View style={styles.containerProfile}>
                    <View style={styles.profileCircle1}>
                        <View style={styles.profileTriangle1}></View>
                    </View>

                    <View style={styles.profileCircle2}>
                        <View style={styles.profileTriangle2}></View>
                    </View>

                    <View style={styles.profileCircle3}>
                        <View style={styles.profileTriangle3}></View>
                    </View>

                    <View style={styles.profileTop}>
                        <View style={{ flexDirection: 'row', alignItems: 'center', gap: 10 }}>
                            <TouchableOpacity
                                onPress={() => {
                                    closeModalControls('profile');
                                }}

                            >
                                <Ionicons name={'chevron-back-outline'} color={'#fff'} size={28}></Ionicons>
                            </TouchableOpacity>
                            <Text style={styles.profileTopText}>Perfil</Text>
                        </View>
                        <TouchableOpacity
                            onPress={() => setIsCloseModalUpdate(true)}
                        >
                            <Ionicons name={'pencil-outline'} color={'#fff'} size={28}></Ionicons>
                        </TouchableOpacity>
                    </View>
                </View>

                <View style={styles.profileInfo}>
                    <View style={styles.containerProfileInfo}>
                        <View style={styles.userIconBg}>
                            <View style={styles.userIcon}>
                                <Ionicons name='ios-person' color={'#F1E2A8'} size={50}></Ionicons>
                            </View>
                        </View>
                    </View>
                </View>


                <Text style={styles.profileTitle}>{clientsData.name}</Text>
                <Text style={styles.profileId}>{clientsData.id}</Text>


                <View style={styles.containerContent}>
                    <Text style={styles.profileInfoTitle}>Informações sobre a conta</Text>
                    <Text style={styles.nameInfo}>E-mail</Text>
                    <Text style={styles.info}>{clientsData.email}</Text>
                    <Text style={styles.nameInfo}>Senha</Text>
                    <Text style={styles.info}>{clientsData.password}</Text>
                    <Text style={styles.nameInfo}>Telefone</Text>
                    <Text style={styles.info}>{clientsData.telefone}</Text>
                    <Text style={styles.nameInfo}>CPF</Text>
                    <Text style={styles.info}>{clientsData.cpf}</Text>
                    <Text style={styles.profileInfoTitle}>Endereço</Text>
                    <Text style={styles.nameInfo}>Número</Text>
                    <Text style={styles.info}>{clientsData.num}</Text>
                    <Text style={styles.nameInfo}>Rua</Text>
                    <Text style={styles.info}>{clientsData.street}</Text>
                    <Text style={styles.nameInfo}>Bairro</Text>
                    <Text style={styles.info}>{clientsData.bairro}</Text>
                    <Text style={styles.nameInfo}>Cidade</Text>
                    <Text style={styles.info}>{clientsData.city}</Text>
                    <Text style={styles.nameInfo}>Estado</Text>
                    <Text style={styles.info}>{clientsData.state}</Text>
                    <Text style={styles.profileInfoTitle}>Conta Bancária</Text>
                    <Text style={styles.nameInfo}>Número do banco</Text>
                    <Text style={styles.info}>{clientsData.numBank}</Text>
                    <Text style={styles.nameInfo}>Agência</Text>
                    <Text style={styles.info}>{clientsData.agency}</Text>
                    <Text style={styles.nameInfo}>Conta corrente</Text>
                    <Text style={styles.info}>{clientsData.currentAcc}</Text>
                    <Text style={styles.nameInfo}>Débito automático</Text>
                    <Text style={styles.info}>{clientsData.autoDebit}</Text>

                    <View style={styles.containerButton}>
                        <TouchableOpacity
                            style={styles.btnLogOut}
                        >
                            <Text style={styles.btnLogOutText}
                                onPress={() => exitAccount()}
                            >Sair da conta</Text>
                        </TouchableOpacity>

                        <TouchableOpacity
                            style={styles.btnDeleteAccount}
                            onPress={() => deleteConfirmation()}
                        >
                            <Text style={styles.btnDeleteAccountText}>Excluir conta</Text>
                        </TouchableOpacity>
                    </View>
                </View>
            </ScrollView>
        </View>
    </>
}
