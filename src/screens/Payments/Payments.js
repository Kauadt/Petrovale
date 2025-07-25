import React, { useState } from "react";
import { Text, View, TouchableOpacity, TextInput, ScrollView, Image } from 'react-native';
import { styles } from "./styles";
import { Ionicons } from '@expo/vector-icons';
import { Picker } from '@react-native-picker/picker';


const listTypes = [
    { id: 0, name: 'Lavagem completa', unit: 'Petrovale Cajati', price: 52.10, date: '18/02' },
    { id: 1, name: 'Gasolina Comum', unit: 'Petrovale Miracatu', price: 100.00, date: '19/02' },
    { id: 2, name: 'Estacionamento rotativo', unit: 'Petrovale Jacupiranga', price: 20.00, date: '24/04' }
]

const paymentForm = [
    { form: 'Selecione a forma de pagamento', valor: 1 },
    { form: 'Crédito', valor: 2 },
    { form: 'Débito', valor: 3 }
];


let formItems = paymentForm.map((v, k) => {
    return <Picker.Item
        key={k}
        value={k}
        label={v.form}
    ></Picker.Item>
})


export const Payments = () => {

    const [formPay, setFormPay] = useState(0);

    return <>
        <ScrollView>
            <View style={styles.container}>

                <View style={styles.navTop}>
                    <TouchableOpacity style={styles.btnBack}>
                        <Ionicons name='chevron-back-outline' color={'#fff'} size={35}></Ionicons>
                    </TouchableOpacity>
                    <Text style={styles.navTopTitle}>Pagamento</Text>
                </View>

                <TouchableOpacity style={styles.btnAddressPay}>
                    <Text style={styles.btnAddressPayText}>Usar endereço padrão</Text>
                </TouchableOpacity>

                <View style={styles.containerRow}>
                    <View style={styles.row}></View>
                    <Text style={styles.orText}>ou</Text>
                    <View style={styles.row}></View>
                </View>

                <Text style={styles.addressPayTitle}>Adicionar endereço</Text>

                <Text style={styles.addressLabel}>Número</Text>
                <TextInput
                    style={styles.inputAddress}
                    placeholder="Digite o número"
                    placeholderTextColor={'#bebebe'}
                ></TextInput>
                <Text style={styles.addressLabel}>Rua</Text>
                <TextInput
                    style={styles.inputAddress}
                    placeholder="Digite o número"
                    placeholderTextColor={'#bebebe'}
                ></TextInput>
                <Text style={styles.addressLabel}>Bairro</Text>
                <TextInput
                    style={styles.inputAddress}
                    placeholder="Digite o número"
                    placeholderTextColor={'#bebebe'}
                ></TextInput>
                <Text style={styles.addressLabel}>Cidade</Text>
                <TextInput
                    style={styles.inputAddress}
                    placeholder="Digite o número"
                    placeholderTextColor={'#bebebe'}
                ></TextInput>
                <Text style={styles.addressLabel}>Estado</Text>
                <TextInput
                    style={styles.inputAddress}
                    placeholder="Digite o número"
                    placeholderTextColor={'#bebebe'}
                ></TextInput>

                <View style={styles.containerExpenses}>
                    {listTypes.map((expenses) => (
                        <View style={styles.cardExpense} key={expenses.id}>

                            <View style={styles.cardExpenseTop}>
                                <Text style={styles.expenseName}>{expenses.name}</Text>
                                <View style={{ flexDirection: 'row', gap: 5, justifyContent: 'flex-end' }}>
                                    <Ionicons name='ios-calendar' color={'#7DB132'} size={20}></Ionicons>
                                    <Text style={styles.expenseDate}>{expenses.date}</Text>
                                </View>

                            </View>

                            <View style={styles.cardExpenseBottom}>
                                <Text style={styles.expensePrice}>R$ {expenses.price}</Text>
                                <View style={{ flexDirection: 'row', gap: 5, justifyContent: 'flex-end' }}>
                                    <Image source={require('../../../assets/greenPoint-icon.png')} style={styles.expensePointImg}></Image>
                                    <Text style={styles.expenseUnitName}>{expenses.unit}</Text>
                                </View>
                            </View>
                        </View>
                    ))}
                </View>

                <View style={styles.containerPicker}>
                    <Picker
                        style={styles.picker}
                        selectedValue={formPay}
                        onValueChange={(itemValue, itemIndex) => setFormPay(itemValue)}
                    >
                        {formItems}
                    </Picker>
                </View>



                <View style={styles.containerPayDetails}>
                    <View style={styles.payDetailsTop}>
                        <Ionicons name="card" color={'#DD9D43'} size={30}></Ionicons>
                        <Text style={styles.payDetailsTitle}>Detalhes do pagamento</Text>
                    </View>
                    <View style={styles.payDetails}>
                        <Text style={styles.payDetailsText}>Taxa de entrega</Text>
                        <Text style={styles.payDetailsText}>R$ 215,45</Text>
                    </View>

                    <View style={styles.payDetails}>
                        <Text style={styles.payDetailsText}>Subtotal dos produtos</Text>
                        <Text style={styles.payDetailsText}>R$ 20</Text>
                    </View>
                    <View style={styles.payDetailsPrice}>
                        <Text style={styles.payDetailsPriceText}>Total</Text>
                        <Text style={styles.payDetailsPriceTotal}>R$ 235,45</Text>
                    </View>
                </View>

            </View>
        </ScrollView>

        <View style={styles.navbar}>
            <Text style={styles.pricePayText}>R$ 235,45</Text>
            <View style={styles.buttonsPay}>
                <TouchableOpacity
                    style={styles.btnMonthlyPay}
                    onPress={() => { alert('add conta mensal') }}
                >
                    <Text style={styles.btnMonthlyText}>Conta Mensal</Text>
                </TouchableOpacity>
                <TouchableOpacity
                    style={styles.btnBuyPay}
                    onPress={() => { alert('Transação concluida com sucesso') }}
                >
                    <Text style={styles.btnBuyText}>Comprar</Text>
                </TouchableOpacity>
            </View>
        </View>

    </>
}