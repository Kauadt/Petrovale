 import { StyleSheet } from "react-native";
 
 export const styles = StyleSheet.create({

    container: {
      flex: 1,
      backgroundColor: '#EFF2ED',
      paddingHorizontal: 24,
      paddingTop: 20,
      alignItems: 'center'
    },
  
    navTopExpenses: {
      width: '100%',
      flexDirection: 'row',
      alignItems: 'center',
      gap: 20
    },
  
    btnBack: {
      backgroundColor: '#DD9D43',
      width: 45,
      height: 45,
      borderRadius: 100,
      justifyContent: 'center',
      alignItems: 'center'
    },
  
    expensesNavTopTitle: {
      fontSize: 22,
      fontWeight: '500'
    },
  
    containerExpenses: {
      width: '100%',
      marginVertical: 35,
      paddingBottom: 90
    },
  
    cardExpense: {
      width: '100%',
      height: 125,
      backgroundColor: '#fff',
      elevation: 5,
      borderRadius: 5,
      paddingHorizontal: 13,
      paddingVertical: 22,
      marginBottom: 10,
      justifyContent: 'space-between'
    },
  
    cardExpenseTop: {
      flexDirection: 'row',
      width: '100%',
      justifyContent: 'space-between',
      alignItems: 'center'
    },
  
    cardExpenseBottom: {
      flexDirection: 'row',
      width: '100%',
      justifyContent: 'space-between',
      alignItems: 'center'
    },
  
    expenseName: {
      fontSize: 18,
    },
  
    expenseUnitName: {
      fontSize: 16,
    },
  
    expenseDate: {
      fontSize: 16,
    },
  
    expensePrice: {
      fontSize: 28,
      fontWeight: '600'
    },
  
    expensePointImg: {
      width: 20,
      height: 20
    },
  
    navbar: {
      width: '100%',
      height: 65,
      backgroundColor: '#fff',
      position: 'absolute',
      bottom: 0,
      flexDirection: 'row',
      alignItems: 'center',
      justifyContent: 'space-between',
      paddingHorizontal: 30
    },
  
    btnNavbarExpenses: {
      width: 120,
      backgroundColor: '#258D5C',
      height: 40,
      justifyContent: 'center',
      alignItems: 'center',
      borderRadius: 5
    },
  
    btnNavbarExpensesText:{
      color: '#fff',
      fontWeight: 'bold'
    },
  
    totalExpensesText:{
      fontSize: 22,
      fontWeight: 'bold'
    }  
  });