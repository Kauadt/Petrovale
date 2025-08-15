import React from 'react';
import { styles } from './styles';
import { Text, View, TouchableOpacity, ScrollView, Image } from 'react-native';
import { Ionicons } from '@expo/vector-icons';


const listExpenses = [
    { id: 0, name: 'Lavagem completa', unit: 'Petrovale Cajati', price: 52.10, date: '18/02' },
    { id: 1, name: 'Gasolina Comum', unit: 'Petrovale Miracatu', price: 100.00, date: '19/02' },
    { id: 2, name: 'Estacionamento rotativo', unit: 'Petrovale Jacupiranga', price: 20.00, date: '24/04' },
    { id: 3, name: ' Lavagem Simples', unit: 'Petrovale Registro', price: 30.00, date: '10/10' },
    { id: 4, name: ' Lavagem Simples', unit: 'Petrovale Registro', price: 30.00, date: '10/10' },
    { id: 5, name: ' Lavagem Simples', unit: 'Petrovale Registro', price: 30.00, date: '10/10' }
]

function sumExpenses() {
    sum = 0;
    for (i = 0; i < listExpenses.length; i++) {
        sum = listExpenses[i].price + sum;
    }
    return sum;
}


export const Expenses = ({ closeModalControls }) => {

    return <>
        <View style={{ flex: 1 }}>
            <View style={styles.container}>

                <View style={styles.navTopExpenses}>
                    <TouchableOpacity style={styles.btnBack}
                        onPress={() => closeModalControls('expenses')}
                    >
                        <Ionicons name='chevron-back-outline' color={'#fff'} size={35}></Ionicons>
                    </TouchableOpacity>
                    <Text style={styles.expensesNavTopTitle}>Minhas Despesas</Text>
                </View>

                <View style={styles.containerExpenses}>
                    <ScrollView>
                        {listExpenses.map((expenses) => (
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
                    </ScrollView>
                </View>
            </View>

            <View style={styles.navbar}>
                <Text style={styles.totalExpensesText}>R$ {sumExpenses()}</Text>
                <TouchableOpacity
                    style={styles.btnNavbarExpenses}
                    onPress={() => { console.log(alert('Transação realizada com sucesso!')) }}
                >
                    <Text style={styles.btnNavbarExpensesText}>Pagar</Text>
                </TouchableOpacity>
            </View>
        </View>
    </>
}




