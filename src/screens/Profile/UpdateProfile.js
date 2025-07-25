import React, { useState } from "react";
import { Text, View, TextInput, TouchableOpacity, ScrollView, Switch, Alert, DevSettings } from 'react-native';
import { styles } from './styles';
import { Ionicons } from '@expo/vector-icons';
import axios from "axios";
import apiUrl from "../apiConfig";


export const UpdateProfile = ({ closeModal, clientsDetails }) => {



    function clearInput() {
        setName('');
        setEmail('');
        setPassword('');
        setTelefone('');
        setNumAdd('');
        setStreet('');
        setBairro('');
        setCity('');
        setState('');
        setNumBank('');
        setAgency('');
        setCurrentAcc('');
        setIsAutoDebit('');
    }

    clientsData = clientsDetails();
    const [name, setName] = useState(clientsData.name)
    const [email, setEmail] = useState(clientsData.email)
    const [password, setPassword] = useState(clientsData.password)
    const [telefone, setTelefone] = useState(clientsData.telefone)
    const [cpf, setCpf] = useState(clientsData.cpf)
    const [numAdd, setNumAdd] = useState(clientsData.num)
    const [street, setStreet] = useState(clientsData.street)
    const [bairro, setBairro] = useState(clientsData.bairro)
    const [city, setCity] = useState(clientsData.city)
    const [state, setState] = useState(clientsData.state)
    const [numBank, setNumBank] = useState(clientsData.numBank)
    const [agency, setAgency] = useState(clientsData.agency)
    const [currentAcc, setCurrentAcc] = useState(clientsData.currentAcc)
    const id_cliente = clientsData.id

    const [isAutoDebit, setIsAutoDebit] = useState(clientsData.autoDebit === 'Ativo');


    const autoDebitStatus = () => {
        debitStatus = isAutoDebit ? 'Ativo' : 'Inativo'
        return debitStatus
    }



    async function editData() {
        const obj = {
            name, email,
            password, telefone,
            cpf, numAdd,
            street, bankAccId: clientsData.bankAccId,
            bairro, city,
            state, numBank,
            agency, currentAcc,
            autoDebit: autoDebitStatus(), 
            id_cliente
        };

        const res = await axios.post(apiUrl + "editar.php", obj);
        console.log(res.data)
        if (res.data.success === true) {
            console.log("Calling editData function...");
            clearInput();
            reLogin()
        }

        if (res.data.success === 'Email já Cadastrado!') {
            console.log("Server response:", res.data);

            dataExists();
        }
    }

   
    const dataExists = () =>
        Alert.alert(
            "Erro ao Salvar",
            "Email Já Cadastrado",
            [
                { text: "OK" }
            ],
            { cancelable: true }
        );

    const reLogin = () =>
        Alert.alert(
            "Informações alteradas",
            "Por favor, realize o login novamente",
            [
                { text: "OK", onPress: () => DevSettings.reload() }
            ],
            { cancelable: true }
        );



    return <>

        <View style={styles.container}>
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
                                onPress={() => closeModal()}
                            >
                                <Ionicons name={'chevron-back-outline'} color={'#fff'} size={28}></Ionicons>
                            </TouchableOpacity>
                            <Text style={styles.profileTopText}>Alterar informações</Text>
                        </View>
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

                    <Text style={styles.nameInfo}>Nome</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o seu nome"
                        onChangeText={(name) => setName(name)}
                        value={name}
                    ></TextInput>

                    <Text style={styles.nameInfo}>E-mail</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o seu e-mail"
                        onChangeText={(email) => setEmail(email)}
                        value={email}
                    ></TextInput>

                    <Text style={styles.nameInfo}>Senha</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o sua senha"
                        secureTextEntry
                        onChangeText={(password) => setPassword(password)}
                        value={password}
                    ></TextInput>
                    <Text style={styles.nameInfo}>Telefone</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o seu telefone"
                        onChangeText={(telefone) => setTelefone(telefone)}
                        value={telefone}
                        keyboardType="numeric"
                    ></TextInput>
                    <Text style={styles.nameInfo}>CPF</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o seu telefone"
                        onChangeText={(cpf) => setCpf(cpf)}
                        value={cpf}
                        keyboardType="numeric"
                    ></TextInput>
                    <Text style={styles.profileInfoTitle}>Endereço</Text>
                    <Text style={styles.nameInfo}>Número</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o número"
                        onChangeText={(numAdd) => setNumAdd(numAdd)}
                        value={numAdd}
                        keyboardType="numeric"
                    ></TextInput>
                    <Text style={styles.nameInfo}>Rua</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite a rua"
                        onChangeText={(street) => setStreet(street)}
                        value={street}
                    ></TextInput>
                    <Text style={styles.nameInfo}>Bairro</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o bairro"
                        onChangeText={(bairro) => setBairro(bairro)}
                        value={bairro}
                    ></TextInput>
                    <Text style={styles.nameInfo}>Cidade</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite a cidade"
                        onChangeText={(city) => setCity(city)}
                        value={city}
                    ></TextInput>
                    <Text style={styles.nameInfo}>Estado</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o estado"
                        onChangeText={(state) => setState(state)}
                        value={state}
                    ></TextInput>
                    <Text style={styles.profileInfoTitle}>Conta Bancária</Text>
                    <Text style={styles.nameInfo}>Número do banco</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o número do banco"
                        onChangeText={(numBank) => setNumBank(numBank)}
                        value={numBank}
                        keyboardType="numeric"
                    ></TextInput>
                    <Text style={styles.nameInfo}>Agência</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o número da agência"
                        onChangeText={(agency) => setAgency(agency)}
                        value={agency}
                    ></TextInput>
                    <Text style={styles.nameInfo}>Conta corrente</Text>
                    <TextInput
                        style={styles.updateProfileInput}
                        placeholder="Digite o número da conta corrente"
                        onChangeText={(currentAcc) => setCurrentAcc(currentAcc)}
                        value={currentAcc}
                    ></TextInput>

                    <View style={styles.containerAutoDebit}>
                        <Text style={styles.autoDebitText}>Débito Automático</Text>
                        <View style={styles.containerSwitch}>
                            <Switch
                                value={isAutoDebit}
                                onValueChange={(isAutoDebit) => setIsAutoDebit(isAutoDebit)}
                                trackColor={{ false: '#767577', true: '#005A40' }}
                                thumbColor={isAutoDebit ? '#258D5C' : '#f4f3f4'}
                            ></Switch>
                        </View>
                    </View>

                    <View style={styles.containerButton}>
                        <TouchableOpacity
                            style={styles.btnSave}
                            onPress={() => editData()}
                        >
                            <Text style={styles.btnSaveText}>Salvar alterações</Text>
                        </TouchableOpacity>
                    </View>



                </View>


            </ScrollView>
        </View>
    </>
}
