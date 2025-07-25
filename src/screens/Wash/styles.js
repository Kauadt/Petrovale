import { StyleSheet } from "react-native";

export const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#EFF2ED',
    paddingHorizontal: 24,
    paddingTop: 20,
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

  inputLabel:{
    marginTop: 25,
    fontSize: 18,
    marginBottom: 3
  },

  btnDate:{
    width: 170,
    borderRadius: 10,
    borderWidth: 1,
    borderColor: '#6F6F6F',
    height: 50,
    justifyContent: 'center',
    alignItems: 'center'
  },
  
  btnDateText:{
    color: '#6F6F6F',
    fontSize: 15
  },

  input:{
    width: 170,
    borderRadius: 10,
    borderWidth: 1,
    borderColor: '#6F6F6F',
    height: 50,
    textAlign: 'center',
    fontSize: 15
  },

  inputText:{
    width: '100%',
    borderRadius: 10,
    borderWidth: 1,
    borderColor: '#6F6F6F',
    height: 50,
    paddingLeft: 14,
    fontSize: 15
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

  buttonsVacancy:{
    flexDirection: 'row',
    gap: 10
  },

  btnBuy: {
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

  btnMonthly: {
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

  priceText:{
    fontSize: 22,
    fontWeight: 'bold'
  },
})