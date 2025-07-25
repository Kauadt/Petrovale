import React, { useState, useMemo, useEffect } from 'react';
import { styles } from './styles';
import { Text, View, TouchableOpacity, TextInput, Alert } from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import { Picker } from '@react-native-picker/picker';
import RadioGroup from 'react-native-radio-buttons-group';
import DateTimePicker from '@react-native-community/datetimepicker';
import axios from 'axios';
import apiUrl from "../apiConfig";


export const Wash = ({ closeModalControls, clientDetails }) => {

    const [search, setSearch] = useState('');

    useEffect(() => {
        listUnits();
        listServices();
    }, [])

    userData = clientDetails();

    const [services, setServices] = useState([]);
    async function listServices() {
        const res = await axios.get(apiUrl + 'listar.php?list=wash&busca=' + search);
        setServices(res.data.result);
    }

    const [units, setUnits] = useState([]);
    async function listUnits() {
        const res = await axios.get(apiUrl + 'listar.php?list=unity&busca=' + search);
        setUnits(res.data.result);
    }

    let unityItems = useMemo(() => {
        return [
            <Picker.Item key={-1} label="Selecione a unidade" value={null} />,
            ...units.map((v, k) => (
                <Picker.Item
                    key={v.id_posto}
                    value={v.id_posto}
                    label={v.nome}
                />
            ))
        ];
    }, [units]);

    const sendServiceDetails = () => {
        let serviceDetails = null
        if (washType == 1) {
            serviceDetails = services[0].idService
        } else if (washType == 2) {
            serviceDetails = services[1].idService
        }
        return serviceDetails;
    }

    const showPrice = () => {
        if (washType == 1) {
            let grossValue = services[0].price;
            let discount = services[0].price * (services[0].discount / 100);
            let netValue = grossValue - discount;
            return netValue;

        } else if (washType == 2) {
            let grossValue = services[1].price;
            let discount = services[1].price * (services[1].discount / 100);
            let netValue = grossValue - discount;
            return netValue;

        } else {
            return '0'
        }
    }

    const dataVerification = () => {
        if (!unity || !washType || !date || !time) {
            Alert.alert(
                "Vá com calma!",
                "Por favor, preencha todos os campos",
                [
                    { text: "OK" }
                ],
                { cancelable: true }
            )
        } else {
            makePayments()
        }
    }


    const makePayments = () => {
        if (userData.autoDebit == 'Ativo') {
            Alert.alert(
                "Agendar Lavagem?",
                "Você deseja agendar uma lavagem?",
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
        const obj = {
            data: formatDate(date, 'insert'),
            idCliente: userData.id,
            idServico: sendServiceDetails(),
            formaPagamento: 'Débito',
            statusPagamento: 'Pago',
            valor: showPrice(),
            horario: formatTime(time, 'insert'),
            placa: plate
        };

        try {
            const res = await axios.post(apiUrl + 'addLavagem.php', obj, {
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


    const radioButtons = useMemo(() => ([
        {
            id: '1',
            label: 'Completa',
            value: 'option1',
            containerStyle: { backgroundColor: '#fff', width: 150, height: 50, paddingLeft: 14, borderRadius: 8 },
            color: '#DD9D43',
            labelStyle: { color: '#000', fontSize: 16 }
        },
        {
            id: '2',
            label: 'Simples',
            value: 'option2',
            containerStyle: { backgroundColor: '#fff', width: 170, height: 50, paddingLeft: 14, borderRadius: 8 },
            color: '#DD9D43',
            labelStyle: { color: '#000', fontSize: 16 }
        }
    ]), []);

    const DateControls = (e, date) => {
        setShowDate(false);
        if (date !== undefined) {
            setDate(date);
        }
    };

    const formatDate = (date, bd) => {
        if (!date) return 'DD/MM/AA';

        const day = date.getDate().toString().padStart(2, '0');
        const month = (date.getMonth() + 1).toString().padStart(2, '0');
        const year = date.getFullYear().toString().padStart(4, '0');
        if (bd == 'insert') {
            return `${year}${month}${day}`;
        } else {
            return `${day}/${month}/${year}`;
        }
    };

    const TimeControls = (e, time) => {
        setShowTime(false);
        if (time !== undefined) {
            setTime(time);
        }
    };

    const formatTime = (time, bd) => {
        const hours = time.getHours().toString().padStart(2, '0');
        const minutes = time.getMinutes().toString().padStart(2, '0');
        if (bd == 'insert') {
            return `${hours}${minutes}`;
        } else {
            return `${hours}:${minutes}`;
        }

    };

    const [washType, setWashType] = useState();
    const [unity, setUnity] = useState(0);
    const [date, setDate] = useState(null);
    const [showDate, setShowDate] = useState(false);
    const [showTime, setShowTime] = useState(false);
    const [time, setTime] = useState(null);
    const [plate, setPlate] = useState('');

    return <>

        <View style={styles.container}>
            <View style={styles.navTop}>
                <TouchableOpacity style={styles.btnBack}
                    onPress={() => closeModalControls('wash')}
                >
                    <Ionicons name='chevron-back-outline' color={'#fff'} size={35}></Ionicons>
                </TouchableOpacity>
                <Text style={styles.navTopTitle}>Lavagem</Text>
            </View>

            <View style={styles.containerPicker}>
                <Picker
                    style={styles.picker}
                    selectedValue={unity}
                    onValueChange={(itemValue, itemIndex) => setUnity(itemValue)}
                >
                    {unityItems}
                </Picker>
            </View>

            <RadioGroup
                radioButtons={radioButtons}
                onPress={setWashType}
                selectedId={washType}
                layout='row'
                containerStyle={{ width: '100%', justifyContent: 'space-between', marginTop: 30 }}
            />


            <View style={{ flexDirection: 'row', justifyContent: 'space-between' }}>
                <View>
                    <Text style={styles.inputLabel}>Entrada</Text>
                    <TouchableOpacity
                        style={styles.btnDate}
                        onPress={() => setShowDate(true)}
                    >
                        <Text style={styles.btnDateText}>{date ? formatDate(date) : 'DD/MM/AA'}</Text>
                    </TouchableOpacity>
                    {showDate && (
                        <DateTimePicker
                            value={date || new Date()}
                            mode="date"
                            is24Hour={true}
                            display="default"
                            onChange={DateControls}
                        />
                    )}
                </View>

                <View>
                    <Text style={styles.inputLabel}>Horário</Text>
                    <TouchableOpacity
                        style={styles.btnDate}
                        onPress={() => setShowTime(true)}
                    >
                        <Text style={styles.btnDateText}>{time == null ? '00:00' : formatTime(time)}</Text>
                    </TouchableOpacity>

                    {showTime && (
                        <DateTimePicker
                            value={time || new Date()}
                            mode="time"
                            is24Hour={true}
                            display="default"
                            onChange={TimeControls}
                        />
                    )}

                </View>

            </View>

            <Text style={styles.inputLabel}>Placa do carro</Text>
            <TextInput
                style={styles.inputText}
                placeholder='Digite a placa do carro'
                placeholderTextColor={'#6F6F6F'}
                onChangeText={(plate) => setPlate(plate)}
                value={plate}
            ></TextInput>
        </View>

        <View style={styles.navbar}>
            <Text style={styles.priceText}>R$ {showPrice()}</Text>
            <View style={styles.buttonsVacancy}>
                <TouchableOpacity
                    style={styles.btnMonthly}
                    onPress={() => { alert('add conta mensal') }}
                >
                    <Text style={styles.btnMonthlyText}>Conta Mensal</Text>
                </TouchableOpacity>
                <TouchableOpacity
                    style={styles.btnBuy}
                    onPress={() => dataVerification()}
                >
                    <Text style={styles.btnBuyText}>Agendar</Text>
                </TouchableOpacity>
            </View>
        </View>
    </>
}




