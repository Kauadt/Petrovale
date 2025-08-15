import { StyleSheet } from "react-native";

export const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#EFF2ED',
        paddingHorizontal: 24,
        paddingTop: 35,
        alignItems: 'center',
        paddingBottom: 90
    },

    navTop: {
        width: '100%',
        flexDirection: 'row',
        alignItems: 'center',
        gap: 20,
        marginBottom: 20
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

    containerListFuel: {
        width: '100%',
        height: 600,
        paddingBottom: 50,
    },

    cardFuel: {
        width: '100%',
        height: 200,
        backgroundColor: '#fff',
        elevation: 5,
        borderRadius: 5,
        padding: 28,
        justifyContent: 'space-between',
        marginBottom: 20
    },

    nameFuel: {
        fontSize: 22,
        fontWeight: '600'
    },


    btnFuel: {
        width: 120,
        height: 40,
        backgroundColor: '#258D5C',
        borderRadius: 5,
        justifyContent: 'center',
        alignItems: 'center',
        position: 'absolute',
        bottom: 0,
        right: 0
    },

    btnFuelText: {
        fontSize: 14,
        color: '#fff',
        fontWeight: 'bold',
    },

    containerPrice: {
        height: 80,
        justifyContent: 'space-between'
    },

    priceFuel: {
        fontSize: 32,
        fontWeight: 'bold'
    },

    discountFuel: {
        width: 90,
        backgroundColor: '#D9D9D9',
        textAlign: 'center',
        textAlignVertical: 'center',
        borderRadius: 5,
        fontSize: 16,
        fontWeight: 'bold',
        color: '#3D3D3D',
        paddingVertical: 4,

    },

    containerSimulation: {
        width: '100%',
        height: 250,
        backgroundColor: '#EDF2F0',
        position: 'absolute',
        bottom: 0,
        borderTopLeftRadius: 30,
        borderTopRightRadius: 30,
        borderStyle: 'solid',
        borderWidth: 1,
        borderColor: '#0000001f',
        flexDirection: 'row',
        paddingHorizontal: 30,
        paddingBottom: 30,
        paddingTop: 60,
        alignItems: 'center',
        justifyContent: 'center'
    },

    iconSwap:{
       paddingTop: 20
    },

    inputSimulation: {
        width: 145,
        height: 58,
        borderStyle: 'solid',
        borderWidth: 2,
        borderColor: '#6F6F6F',
        borderRadius: 10,
        paddingLeft: 10
    },

    labelInput:{
        textAlign: 'right',
        fontSize: 18,
        fontWeight: '500'
    }



})
