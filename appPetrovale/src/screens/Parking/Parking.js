import React, { useState, useMemo, useEffect } from 'react';
import { styles } from './styles';
import { Picker } from '@react-native-picker/picker';
import { Text, View, TouchableOpacity, ScrollView, TextInput, Alert } from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import RadioGroup from 'react-native-radio-buttons-group';
import Slider from '@react-native-community/slider';
import { VacancyRadio } from '../../../components/VacancyRadio';
import DateTimePicker from '@react-native-community/datetimepicker';
import axios from 'axios';
import apiUrl from "../apiConfig";

export const Parking = ({ closeModalControls, clientDetails }) => {
    const [search, setSearch] = useState('');


    userData = clientDetails();

    useEffect(() => {
        listVacancyData();
        listUnits()
        listServices()
    }, [search, vacancies]);

    const [vacancies, setVacancies] = useState([])
    async function listVacancyData() {
        const res = await axios.get(apiUrl + 'listar.php?list=parking&busca=' + search);
        setVacancies(res.data.result);
    }

    const [units, setUnits] = useState([]);
    async function listUnits() {
        const res = await axios.get(apiUrl + 'listar.php?list=unity&busca=' + search);
        setUnits(res.data.result);
    }

    const [services, setServices] = useState([]);
    async function listServices() {
        const res = await axios.get(apiUrl + 'listar.php?list=services&busca=' + search);
        setServices(res.data.result);
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

    const radioButtons = useMemo(() => ([
        {
            id: '1',
            label: 'Rotativo',
            value: 'option1',
            containerStyle: { backgroundColor: '#fff', width: 150, height: 50, paddingLeft: 14, borderRadius: 8 },
            color: '#DD9D43',
            labelStyle: { color: '#000', fontSize: 16 }
        },
        {
            id: '2',
            label: 'Mensal',
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

    const msgNotNull = () => {
        Alert.alert(
            "Vá com calma!",
            "Por favor, preencha todos os campos",
            [
                { text: "OK" }
            ],
            { cancelable: true }
        )
    }

    const showPrice = () => {
        if (vacancyType == 1) {
            let grossValue = services[0].price;
            let discount = services[0].price * (services[0].discount / 100);
            let netValue = grossValue - discount;
            return netValue;

        } else if (vacancyType == 2) {
            let grossValue = services[1].price;
            let discount = services[1].price * (services[1].discount / 100);
            let netValue = grossValue - discount;
            return netValue;

        } else {
            return '0'
        }
    }

    const [vacancyType, setVacancyType] = useState();
    const [vacancy, setVacancy] = useState(null);
    const [unity, setUnity] = useState(0);
    const [hour, setHour] = useState(0);
    const [date, setDate] = useState(null);
    const [showDate, setShowDate] = useState(false);
    const [plate, setPlate] = useState('');

    const dataVerification = () => {
        if (vacancyType == '1') {
            (!unity || !date || !plate || hour == 0 || !vacancy) ? msgNotNull() : makePayments()
        } else if (vacancyType == '2') {
            (!unity || !date || !plate || !vacancy) ? msgNotNull() : makePayments()
        } else {
            msgNotNull()
        }
    }

    const makePayments = () => {
        if (userData.autoDebit == 'Ativo') {
            Alert.alert(
                "Reservar vaga?",
                "Você deseja reservar uma vaga?",
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

    const sendServiceDetails = () => {
        let serviceDetails = null
        if (vacancyType == 1) {
            serviceDetails = services[0].idService
        } else if (vacancyType == 2) {
            serviceDetails = services[1].idService
        }
        return serviceDetails;
    }

    const add = async () => {
        const obj = {
            data: formatDate(date, 'insert'),
            idCliente: userData.id,
            idServico: sendServiceDetails(),
            formaPagamento: 'Débito',
            statusPagamento: 'Pago',
            valor: showPrice(),
            tempo: hour,
            placa: plate,
            id_vaga: selectedVacancy
        };

        try {
            const res = await axios.post(apiUrl + 'addEstacionamento.php', obj, {
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

    const [selectedVacancy, setSelectedVacancy] = useState(null);

    const handleVacancySelect = (value) => {   
        setSelectedVacancy(value);
    };


    return <>
        <ScrollView>
            <View style={styles.container}>
                <View style={styles.navTop}>
                    <TouchableOpacity style={styles.btnBack}
                        onPress={() => closeModalControls('parking')}
                    >
                        <Ionicons name='chevron-back-outline' color={'#fff'} size={35}></Ionicons>
                    </TouchableOpacity>
                    <Text style={styles.navTopTitle}>Estacionamento</Text>
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
                    onPress={setVacancyType}
                    selectedId={vacancyType}
                    layout='row'
                    containerStyle={{ width: '100%', justifyContent: 'space-between', marginTop: 30 }}
                />

                <View style={styles.containerVacancy}>
                    <VacancyRadio vacancies={vacancies} onSelect={(value) => setVacancy(value)} onVacancySelect={handleVacancySelect} />

                    <View style={styles.selectedVacancy}>
                        <Text style={styles.selectedVacancyTitle}>Vaga Selecionada</Text>
                        <Text style={styles.selectedVacancyText}>{vacancy}</Text>
                    </View>
                </View>

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

                {vacancyType === '1' && (
                    <View>
                        <View style={styles.containerSliderTitle}>
                            <Text style={styles.inputLabel}>Horas</Text>
                            <Text style={styles.sliderLabel}>{hour.toFixed()} {hour > 1 ? 'Horas' : 'Hora'}</Text>
                        </View>

                        <Slider
                            minimumValue={0}
                            maximumValue={24}
                            minimumTrackTintColor='#258D5C'
                            maximumTrackTintColor={color}
                            thumbTintColor='#258D5C'
                            value={hour}
                            style={styles.inputSlider}
                            onValueChange={(value) => setHour(value)}
                        />
                    </View>
                )}

                <Text style={styles.inputLabel}>Placa do carro</Text>
                <TextInput
                    style={styles.inputText}
                    placeholder='Digite a placa do carro'
                    placeholderTextColor={'#6F6F6F'}
                    onChangeText={(plate) => setPlate(plate)}
                    value={plate}
                ></TextInput>


            </View>
        </ScrollView>

        <View style={styles.navbar}>
            <Text style={styles.priceText}>R$ {showPrice()}</Text>
            <View style={styles.buttonsVacancy}>
                <TouchableOpacity
                    style={styles.btnMonthly}
                    onPress={() => { alert(selectedVacancy) }}
                >
                    <Text style={styles.btnMonthlyText}>Conta Mensal</Text>
                </TouchableOpacity>
                <TouchableOpacity
                    style={styles.btnBuy}
                    onPress={() => dataVerification()}
                >
                    <Text style={styles.btnBuyText}>Reservar</Text>
                </TouchableOpacity>
            </View>
        </View>
    </>
}




