import { StyleSheet } from "react-native";

export const styles = StyleSheet.create({

    //navbar 
  
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
  
    // Units
  
  
  
    containerHome: {
      flex: 1,
      backgroundColor: '#EFF2ED',
      paddingHorizontal: 24,
      paddingTop: 60
    },
  
    //Welcome Nav
  
    navTop: {
      flexDirection: 'row',
      justifyContent: 'space-between'
    },
  
    navTopUserIcon: {
      width: 60,
      height: 60,
      backgroundColor: '#DD9D43',
      borderRadius: 169,
      justifyContent: 'center',
      alignItems: 'center'
    },
  
    welcomeNavText: {
      fontSize: 28,
      width: 160,
      lineHeight: 32,
      fontWeight: '400'
    },
  
    // Services area
  
    containerServices: {
      marginTop: 45,
      width: '100%',
      flexDirection: 'row',
      justifyContent: 'space-between',
    },
  
    cardServices: {
      width: 85,
      height: 85,
      backgroundColor: '#E4E4E4',
      borderRadius: 25,
      alignItems: 'center',
      justifyContent: 'center'
    },
  
    containerCardServices: {
      alignItems: 'center',
      justifyContent: 'center',
      gap: 5
    },
  
    iconCardServices: {
      width: 40,
      height: 40
    },
  
    textCardServices: {
      fontSize: 12,
      color: '#6F6F6F'
    },
  
    // Monthly bill
  
    cardMonthly: {
      marginTop: 35,
      width: '100%',
      height: 210,
      backgroundColor: '#258D5C',
      borderRadius: 5,
      position: 'relative',
      overflow: 'hidden',
      elevation: 3
  
    },
  
    monthlyTop: {
      flexDirection: 'row',
      padding: 20,
      justifyContent: 'space-between',
      alignItems: 'center'
    },
  
    containerMonthlyBalance: {
      width: '100%',
      height: 75,
      paddingHorizontal: 20,
      alignItems: 'flex-end',
    },
  
    monthlyBalanceLabel: {
      fontSize: 14,
      color: '#ADD3B9'
    },
  
    monthlyBalanceText: {
      fontSize: 26,
      color: '#F1E2A8',
      fontWeight: 'bold'
    },
  
    monthlyTopText: {
      fontSize: 18,
      color: '#FFFFFF',
      fontWeight: '500'
    },
  
    monthlyBtn: {
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
  
    monthlyBtnText: {
      color: '#000',
      fontWeight: '500',
      fontSize: 14
    },
  
    monthlyCircle1: {
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
  
    monthlyTriangle1: {
      borderLeftWidth: 25,
      borderRightWidth: 25,
      borderBottomWidth: 47,
      borderLeftColor: 'transparent',
      borderRightColor: 'transparent',
      borderBottomColor: '#005A4063',
      transform: [{ rotate: '-20deg' }],
      marginLeft: 12
    },
  
    monthlyCircle2: {
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
  
    monthlyTriangle2: {
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
  
    monthlyCircle3: {
      width: 145,
      height: 130,
      borderRadius: 100,
      position: 'absolute',
      backgroundColor: '#7DB13230',
      bottom: 20,
      right: -28,
      alignItems: 'center',
      paddingTop: 20
    },
  
    monthlyTriangle3: {
      borderLeftWidth: 40,
      borderRightWidth: 40,
      borderBottomWidth: 70,
      borderLeftColor: 'transparent',
      borderRightColor: 'transparent',
      borderBottomColor: '#005A4063',
      transform: [{ rotate: '-12deg' }],
      position: 'absolute',
      top: -10,
      right: 18
    },
  
    // Store
  
    containerStore: {
      width: '100%',
      marginTop: 40
    },
  
    storeHeader: {
      flexDirection: 'row',
      justifyContent: 'space-between',
      alignItems: 'center',
      paddingEnd: 10
    },
  
    storeTitle: {
      fontSize: 22,
      fontWeight: '500'
    },
  
    storeBtnShowMore: {
      width: 80,
      height: 35,
      alignItems: 'center',
      justifyContent: 'flex-end'
    },
  
    storeBtnShowMoreText: {
      color: '#6F6F6F'
    },
  
    containerProducts: {
      width: '100%',
      paddingTop: 18,
      flexDirection: 'row',
      justifyContent: 'space-between',
      flexWrap: 'wrap',
      rowGap: 13,
      paddingBottom: 20
    },
  
    storeProduct: {
      width: '48%',
      height: 148,
      backgroundColor: '#98C15F',
      borderRadius: 5,
      justifyContent: 'center',
      alignItems: 'center'
    },
  
    // Units
  
    containerUnits: {
      width: '100%',
      paddingBottom: 80
    },
  
    unitsHeadTitle: {
      fontSize: 22,
      fontWeight: '500',
      marginBottom: 20,
      marginTop: 20
    },
  
    unitCard: {
      width: '100%',
      minHeight: 75,
      backgroundColor: '#FFFFFF',
      elevation: 5,
      paddingHorizontal: 10,
      flexDirection: 'row',
      alignItems: 'center',
      borderRadius: 5,
      gap: 10,
      paddingVertical: 10,
      marginBottom: 8
    },
  
    unityPointImg: {
      width: 35,
      height: 35
    },
  
    unitCardName: {
      fontSize: 18,
      fontWeight: '500',
      color: '#000'
    },
  
    unitCardAddress: {
      fontSize: 16,
      color: '#bebebe',
      width: 300,
      minHeight: 16
    },
  
  
  });