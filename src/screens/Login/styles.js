import { StyleSheet } from 'react-native';

export const styles = StyleSheet.create({
    container:{
        flex: 1,
        backgroundColor: '#f5f5f5',
        paddingTop: 60
    },

    navTop: {
        width: '100%',
        flexDirection: 'row',
        alignItems: 'center',
        gap: 20,
        paddingHorizontal: 24
        
    },

    btnBack: {
        backgroundColor: '#DD9D43',
        width: 40,
        height: 40,
        borderRadius: 100,
        justifyContent: 'center',
        alignItems: 'center'
    },

    navTopTitle: {
        fontSize: 22,
        fontWeight: '500'
    },

    containerLogo: {
        width: '100%',
        alignItems: 'center',
        marginTop: 30,
        paddingBottom: 30,
    },

    containerForm:{
        paddingHorizontal: 24,
        paddingTop: 5,
        justifyContent: 'center',
    },

    loginTitle:{
        fontSize: 22,
        fontWeight: '600'
    },

    loginSubTitle:{
        fontSize: 18,
        fontWeight: '500',
        color: '#bebeb6'
    },

    form:{
        paddingTop: 35
    },

    formLoginInput:{
        width: '100%',
        borderColor: '#bebebe',
        borderWidth: 1.5,
        height: 50,
        paddingLeft: 12,
        fontSize: 16,
        borderRadius: 10,
        marginBottom: 25
    },

    formLoginLabel:{
        fontSize: 16,
        paddingLeft: 5,
        paddingBottom: 3,
        fontWeight:  '500'
    },

    formLoginBtn:{
        width: '100%',
        backgroundColor: '#258D5C',
        alignItems: 'center',
        justifyContent: 'center',
        height: 48,
        borderRadius: 10
    },

    formLoginBtnText:{
        color: '#fff',
        fontSize: 16,
        fontWeight: '600'
    },

    textRegister:{
        width: '100%',
        textAlign: 'center',
        marginTop: 22,
        fontSize: 16,
        fontWeight: '600'
    },

    btnRegister:{
        marginTop: 6,
        width: '100%',
        alignItems: 'center',
    },

    btnRegisterText:{
        fontSize: 16,
        color: '#7DB132',
        fontWeight: 'bold'
    }


})