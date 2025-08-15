import { StyleSheet } from "react-native";

export const styles = StyleSheet.create({

  container: {
    flex: 1,
    backgroundColor: '#EFF2ED',
    paddingHorizontal: 24,
    paddingTop: 60,
    paddingBottom: 100
  },

  navTop: {
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

  navTopTitle: {
    fontSize: 22,
    fontWeight: '500'
  },


  btnAddressPay: {
    marginTop: 32,
    width: '100%',
    height: 50,
    backgroundColor: '#fff',
    borderRadius: 10,
    elevation: 1.5,
    justifyContent: 'center',
    alignItems: 'center'
  },

  btnAddressPayText: {
    fontSize: 16,
    fontWeight: '600'
  },

  containerRow: {
    width: '100%',
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginTop: 20
  },

  row: {
    width: '42%',
    borderTopWidth: 1,
    borderTopColor: '#6F6F6F'
  },

  orText: {
    fontSize: 18,
    color: '#6F6F6F'
  },

  addressPayTitle: {
    fontSize: 22,
    marginVertical: 28,
    fontWeight: '600',

  },

  inputAddress: {
    width: '100%',
    height: 55,
    borderRadius: 10,
    borderWidth: 1,
    borderColor: '#BEBEBE',
    paddingLeft: 10,
    fontSize: 16,
    marginBottom: 15
  },

  addressLabel: {
    fontSize: 15,
    fontWeight: '600',
    marginBottom: 2
  },

  containerExpenses: {
    width: '100%',
    marginVertical: 20,
  },

  cardExpense: {
    width: '100%',
    height: 135,
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


  containerPicker: {
    width: '100%',
    height: 55,
    borderRadius: 10,
    backgroundColor: '#258D5C',
    marginTop: 35,
    justifyContent: 'center'
  },
  picker: {
    width: '100%',
    color: '#fff',
  },


  containerPayDetails: {
    marginTop: 30,
    width: '100%',
    height: 240,
    borderWidth: 1,
    borderColor: '#6F6F6F',
    borderRadius: 10,
    padding: 20 
  },


  payDetailsTop: {
    width: '100%',
    height: 30,
    flexDirection: 'row',
    alignItems: 'center',
    marginBottom: 30
  },

  payDetailsTitle:{
    fontSize: 16,
    marginLeft: 10,
    fontWeight: '600'
  },

  payDetails:{
    width: '100%',
    height: 30,
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between'
  },

  payDetailsText:{
    height: 30,
    color: '#6f6f6f'
  },

  payDetailsPrice:{
    width: '100%',
    height: 90,
    flexDirection: 'row',
    alignItems: 'flex-end',
    justifyContent: 'space-between'
  },

  payDetailsPriceText:{
    color: '#000',
    fontSize: 16,
    fontWeight: '500'
  },
  payDetailsPriceTotal:{
    fontSize: 28,
    fontWeight: 'bold',
    color: '#DD9D43'
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

      buttonsPay:{
        flexDirection: 'row',
        gap: 10
      },
    
      btnBuyPay: {
        width: 80,
        backgroundColor: '#258D5C',
        height: 40,
        justifyContent: 'center',
        alignItems: 'center',
        borderRadius: 5
      },
    
      btnBuyText:{
        color: '#fff',
        fontWeight: 'bold'
      },
    
      btnMonthlyPay: {
        width: 120,
        backgroundColor: '#D9D9D9',
        height: 40,
        justifyContent: 'center',
        alignItems: 'center',
        borderRadius: 5
      },
    
      btnMonthlyText:{
        color: '#000',
        fontWeight: 'bold'
      },
    
      pricePayText:{
        fontSize: 22,
        fontWeight: 'bold'
      }  








})