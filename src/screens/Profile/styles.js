import { StyleSheet } from "react-native";

export const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#EFF2ED',
        paddingBottom: 30,
    },

    containerProfile: {
        width: '100%',
        height: 255,
        backgroundColor: '#258D5C',
        position: 'relative',
        overflow: 'hidden',
        elevation: 3,
        paddingTop: 30,
    },

    profileTop: {
        flexDirection: 'row',
        padding: 20,
        justifyContent: 'space-between',
        alignItems: 'center'
    },

    containerprofileBalance: {
        width: '100%',
        height: 75,
        paddingHorizontal: 20,
        alignItems: 'flex-end',
    },

    profileBalanceLabel: {
        fontSize: 14,
        color: '#ADD3B9'
    },

    profileBalanceText: {
        fontSize: 26,
        color: '#F1E2A8',
        fontWeight: 'bold'
    },

    profileTopText: {
        fontSize: 22,
        color: '#FFFFFF',
        fontWeight: '500'
    },

    profileBtn: {
        width: '100%',
        justifyContent: 'center',
        alignItems: 'center',
        height: 65,
        backgroundColor: '#E4E4E4',
        position: 'absolute',
        bottom: 0,
        borderBottomRightRadius: 5,
        borderBottomLeftRadius: 5,
        zIndex: 999
    },

    profileBtnText: {
        color: '#000',
        fontWeight: '500',
        fontSize: 14
    },

    profileCircle1: {
        width: 130,
        height: 120,
        borderRadius: 100,
        position: 'absolute',
        backgroundColor: '#7DB13230',
        bottom: 40,
        left: -15,
        alignItems: 'center',
        paddingTop: 20
    },

    profileTriangle1: {
        borderLeftWidth: 25,
        borderRightWidth: 25,
        borderBottomWidth: 47,
        borderLeftColor: 'transparent',
        borderRightColor: 'transparent',
        borderBottomColor: '#005A4063',
        transform: [{ rotate: '-20deg' }],
        marginLeft: 12
    },

    profileCircle2: {
        width: 100,
        height: 90,
        borderRadius: 100,
        position: 'absolute',
        backgroundColor: '#7DB13230',
        top: -27,
        right: 110,
        alignItems: 'center',
        paddingTop: 20
    },

    profileTriangle2: {
        borderLeftWidth: 21,
        borderRightWidth: 21,
        borderBottomWidth: 40,
        borderLeftColor: 'transparent',
        borderRightColor: 'transparent',
        borderBottomColor: '#005A4063',
        transform: [{ rotate: '22deg' }],
        position: 'absolute',
        bottom: -12,
        left: 0
    },

    profileCircle3: {
        width: 145,
        height: 130,
        borderRadius: 100,
        position: 'absolute',
        backgroundColor: '#7DB13230',
        bottom: 20,
        right: 28,
        alignItems: 'center',
        paddingTop: 20
    },

    profileTriangle3: {
        borderLeftWidth: 40,
        borderRightWidth: 40,
        borderBottomWidth: 70,
        borderLeftColor: 'transparent',
        borderRightColor: 'transparent',
        borderBottomColor: '#005A4063',
        transform: [{ rotate: '-12deg' }],
        position: 'absolute',
        top: -18,
        right: 13
    },


    navTop: {
        width: '100%',
        flexDirection: 'row',
        alignItems: 'center',
        gap: 20,
        paddingHorizontal: 24

    },

    btnBack: {
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


    profileInfo: {
        width: '100%',
        backgroundColor: '#258D5C'
    },
    containerProfileInfo: {
        width: '100%',
        borderTopLeftRadius: 30,
        borderTopRightRadius: 30,
        backgroundColor: '#EFF2ED',
        height: 60,
        alignItems: 'center',
        position: 'relative',

    },
    userIconBg: {
        width: 110,
        height: 110,
        backgroundColor: '#EFF2ED',
        borderRadius: 100,
        justifyContent: 'center',
        alignItems: 'center',
        position: 'absolute',
        top: -50
    },
    userIcon: {
        width: 90,
        height: 90,
        backgroundColor: '#DD9D43',
        borderRadius: 100,
        justifyContent: 'center',
        alignItems: 'center'
    },

    profileTitle: {
        width: '100%',
        textAlign: 'center',
        fontWeight: '500',
        fontSize: 22
    },

    profileId: {
        width: '100%',
        textAlign: 'center',
        fontWeight: '400',
        fontSize: 14,
        color: '#bebebe'
    },

    containerContent: {
        paddingHorizontal: 18,
        paddingTop: 50

    },

    containerTitle: {
        paddingBottom: 40,
        alignItems: 'center'
    },

    profileInfoTitle: {
        fontSize: 22,
        fontWeight: '500',
        paddingBottom: 50,
        textAlign: 'center',
        width: '100%'
    },

    nameInfo: {
        fontSize: 16,
        fontWeight: '500',
        width: '100%'
    },

    info: {
        color: '#bebebe',
        fontSize: 19,
        marginBottom: 28,
        width: '100%',
        fontWeight: '400'
    },

    containerButton: {
        marginTop: 20,
        gap: 14
    },

    btnLogOut: {
        width: '100%',
        height: 55,
        backgroundColor: '#DD9D43',
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 10
    },

    btnLogOutText: {
        color: '#fff',
        fontSize: 17,
        fontWeight: '500'
    },

    btnDeleteAccount: {
        width: '100%',
        height: 55,
        backgroundColor: '#D9D9D9',
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 10
    },

    btnDeleteAccountText: {
        color: '#000',
        fontSize: 17,
        fontWeight: '500'
    },

    btnSave: {
        width: '100%',
        height: 55,
        backgroundColor: '#258D5C',
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 10
    },

    btnSaveText: {
        color: '#fff',
        fontSize: 17,
        fontWeight: '500'
    },

    updateProfileInput: {
        width: '100%',
        borderColor: '#bebebe',
        borderWidth: 1.5,
        height: 50,
        paddingLeft: 12,
        fontSize: 16,
        borderRadius: 10,
        marginBottom: 25,
        marginTop: 2
    },

    containerAutoDebit: {
        flexDirection: 'row',
        width: '100%',
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'space-between',
        paddingHorizontal: 10,
        paddingVertical: 15,
        marginBottom: 30,
        borderRadius: 10,
        elevation: 2
    },

    containerSwitch: {
        paddingVertical: 2,
        width: 'auto',
        height: 25,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 100,
    },

    autoDebitText: {
        fontSize: 18,
        fontWeight: '600'
    },


})