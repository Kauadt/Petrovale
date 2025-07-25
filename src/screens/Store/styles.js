import { StyleSheet } from "react-native";


export const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#EFF2ED',
  },

  containerInputSearch: {
    flexDirection: 'row',
    marginHorizontal: 24,
    marginTop: 45,
  },

  inputSearch: {
    backgroundColor: '#fff',
    borderRadius: 8,
    color: '#000',
    fontSize: 16,
    position: 'relative',
    height: 45,
    width: '100%',
    paddingLeft: 55
  },

  iconSearch: {
    position: 'absolute',
    top: 10,
    left: 15
  },

  containerProduct:{
    paddingTop: 30,
    marginHorizontal: 24,
    paddingBottom: 160
  },


  cardProduct: {
    width: '100%',
    minHeight: 200,
    backgroundColor: '#FFFFFF',
    borderRadius: 5,
    flexDirection: 'row',
    padding: 12,
    justifyContent: 'space-between',
    marginBottom: 10
  },

  nameProduct: {
    color: '#000',
    fontSize: 22,
    fontWeight: 'bold',
    marginTop: 12
  },

  descriptionProduct: {
    color: '#A2A2A2',
    fontWeight: '500',
    marginTop: 12
  },

  informationSide: {
    width: '60%',
  },

  containerPrice: {
    position: 'absolute',
    bottom: 0,
    flexDirection: 'row',
    gap: 15,
    alignItems: 'center'
  },

  containerImg: {
    width: '39%',
    alignItems: 'center',
    justifyContent: 'center'
  },


  priceProduct:{
    fontSize: 24,
    fontWeight: '700',
    color: '#000'
  },


  discountProduct: {
    backgroundColor: '#D9D9D9',
    padding: 7,
    borderRadius: 5,
    color: '#000'
  },

  navbar: {
    width: '100%',
    height: 60,
    backgroundColor: '#fff',
    position: 'absolute',
    bottom: 0,
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-around'
  },

  navbarHomebtn: {
    width: 50,
    height: 50,
    justifyContent: 'center',
    alignItems: 'center'
  },

  navbarHomebtnIcon: {
    width: 28,
    height: 28
  },

  
})