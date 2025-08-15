import { StyleSheet } from "react-native";


export const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#EFF2ED',
      },
    
      navTopStore: {
        width: '100%',
        flexDirection: 'row',
        alignItems: 'center',
        gap: 20,
        marginTop: 60,
        marginHorizontal: 24
      },
    
      btnBack: {
        backgroundColor: '#DD9D43',
        width: 40,
        height: 40,
        borderRadius: 100,
        justifyContent: 'center',
        alignItems: 'center'
      },
    
      storeNavTopTitle: {
        fontSize: 22,
        fontWeight: '500'
      },


      containerImageProduct:{
        backgroundColor: '#EFF2ED',
        marginTop: 10,
        width: '100%',
        height: '40%',
        justifyContent: 'center',
        alignItems: 'center'
      },

      containerInfoProduct:{
        height: '40%',
        width: '100%',
        backgroundColor: '#fff',
        borderTopRightRadius: 40,
        borderTopLeftRadius: 40,
        elevation: 10,
        padding: 30,
        position: 'absolute',
        bottom: 65
      },


      nameProduct: {
        fontSize: 23,
        fontWeight: '600',
        color: '#000'
      },

      descriptionProduct:{
        marginTop: 10,
        fontSize: 15,
        color: '#bebebe',
        width: '100%',
        maxHeight: 175,
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

      buttonsProduct:{
        flexDirection: 'row',
        gap: 10
      },
    
      btnBuyProduct: {
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
    
      btnMonthlyProduct: {
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
    
      priceProductText:{
        fontSize: 22,
        fontWeight: 'bold'
      }  
})