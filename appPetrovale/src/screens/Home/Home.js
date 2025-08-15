import React, { useState, useEffect } from 'react';
import { styles } from './styles';
import { Text, View, TouchableOpacity, ScrollView, Image, Modal, SafeAreaView, Alert } from 'react-native';
import axios from 'axios';
import { StatusBar } from 'expo-status-bar';
import * as Animatable from 'react-native-animatable';
import { Ionicons } from '@expo/vector-icons';
import { Expenses } from '../Expenses/Expenses';
import { Profile } from '../Profile/Profile';
import { Fuel } from '../Fuel/Fuel';
import { Parking } from '../Parking/Parking';
import { Wash } from '../Wash/Wash';
import { Store } from '../Store/Store';
import { Login } from '../Login/Login';
import { Product } from '../Product/Product';
import apiUrl from "../apiConfig";


export const Home = () => {

  useEffect(() => {
    listProductsData();
    listGasStationData();
  }, [])

  const [listProducts, setListProducts] = useState([]);
  const [search, setSearch] = useState('');


  async function listProductsData() {
    const res = await axios.get(apiUrl + 'listar.php?list=homeScreen&busca=' + search);
    setListProducts(res.data.result);
  }

  const [listGasStation, setListGasStation] = useState([]);
  async function listGasStationData() {
    const res = await axios.get(apiUrl + 'listar.php?list=unity&busca=' + search);
    setListGasStation(res.data.result);
  }

  const [isShowProfile, setIsShowProfile] = useState(false);
  const [isShowFuel, setIsShowFuel] = useState(false);
  const [isShowParking, setIsShowParking] = useState(false);
  const [isShowWash, setIsShowWash] = useState(false);
  const [isShowExpenses, setIsShowExpenses] = useState(false);
  const [isShowStore, setIsShowStore] = useState(false);
  const [isShowProduct, setIsShowProduct] = useState(false);
  const [isBalanceVisible, setIsBalanceVisible] = useState(false);

  const [productNome, setProductNome] = useState('');
  const [productId, setProductId] = useState('');
  const [productDescription, setProductDescription] = useState('');
  const [productDiscount, setProductDiscount] = useState('');
  const [productImage, setProductImage] = useState('');
  const [productPrice, setProductPrice] = useState('');

  showItemsHome = () => {
    return [productNome, productId, productDescription, productDiscount, productImage, productPrice];
  }

  const closeModalControls = (modal) => {
    switch (modal) {
      case 'profile':
        setIsShowProfile(false)
        break;
      case 'fuel':
        setIsShowFuel(false)
        break;
      case 'parking':
        setIsShowParking(false)
        break;
      case 'wash':
        setIsShowWash(false)
        break;
      case 'expenses':
        setIsShowExpenses(false)
        break;
      case 'store':
        setIsShowStore(false)
        break;
      default:
        return undefined

    }
  }

  const closeProductHome = () => {
    setIsShowProduct(false)
  }

  const [userData, setUserData] = useState([])

  const getClientDetails = (data) => {
    setUserData(data)
  }

  const sendClientsDetails = () => {
    return {
      id: userData[0].id,
      name: userData[0].name,
      num: userData[0].num,
      street: userData[0].street,
      city: userData[0].city,
      bairro: userData[0].bairro,
      state: userData[0].state,
      password: userData[0].password,
      cpf: userData[0].cpf,
      telefone: userData[0].telefone,
      email: userData[0].email,
      autoDebit: userData[0].autoDebit,
      currentAcc: userData[0].currentAcc,
      agency: userData[0].agency,
      numBank: userData[0].numBank,
      bankAccId: userData[0].bankAccId,
    }
  }

  const [isOpenLogin, setIsOpenLogin] = useState(true);
  const closeLogin = () => {
    setIsOpenLogin(false);
  };

  return <>

    {/* Login */}

    <Modal
      visible={isOpenLogin}
      transparent={false}
      animationType='slide'
      style={{ flex: 1 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Login closeLogin={closeLogin} getClientDetails={getClientDetails}></Login>
        </Animatable.View>
      </SafeAreaView>
    </Modal>


    {/* Store */}
    <Modal
      visible={isShowStore}
      transparent={false}
      animationType='slide'
      style={{ flex: 1 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Store closeModalControls={closeModalControls}></Store>
        </Animatable.View>
      </SafeAreaView>
    </Modal>

    {/* Expenses */}
    <Modal
      visible={isShowExpenses}
      transparent={false}
      animationType='slide'
      style={{ flex: 1 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Expenses closeModalControls={closeModalControls} clientsDetails={sendClientsDetails}></Expenses>
        </Animatable.View>
      </SafeAreaView>
    </Modal>

    {/* Profile */}
    <Modal
      visible={isShowProfile}
      transparent={false}
      animationType='slide'
      style={{ flex: 1 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Profile closeModalControls={closeModalControls} clientsDetails={sendClientsDetails}></Profile>
        </Animatable.View>
      </SafeAreaView>
    </Modal>


    {/* Fuel */}
    <Modal
      visible={isShowFuel}
      transparent={false}
      animationType='slide'
      style={{ flex: 1 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Fuel closeModalControls={closeModalControls}></Fuel>
        </Animatable.View>
      </SafeAreaView>
    </Modal>

    {/* Parking */}
    <Modal
      visible={isShowParking}
      transparent={false}
      animationType='slide'
      style={{ flex: 1 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Parking closeModalControls={closeModalControls} clientDetails={sendClientsDetails}></Parking>
        </Animatable.View>
      </SafeAreaView>
    </Modal>

    {/* Wash */}

    <Modal
      visible={isShowWash}
      transparent={false}
      animationType='slide'
      style={{ flex: 1 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Wash closeModalControls={closeModalControls} clientDetails={sendClientsDetails}></Wash>
        </Animatable.View>
      </SafeAreaView>
    </Modal>

    <Modal
      visible={isShowProduct}
      transparent={false}
      animationType='slide'
      style={{ flex: 1, marginTop: 0 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1, marginTop: 0 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Product showItemsHome={showItemsHome} closeProduct={closeProductHome} clientsDetails={sendClientsDetails}></Product>
        </Animatable.View>
      </SafeAreaView>
    </Modal>

    <View>
      <StatusBar hidden></StatusBar>
      <ScrollView>
        <View style={styles.containerHome}>


          {/* Welcome and profile */}

          <View style={styles.navTop}>
            <Text style={styles.welcomeNavText}>Olá, {userData && userData[0] && userData[0].name}!</Text>
            <TouchableOpacity style={styles.navTopUserIcon}
              onPress={() => setIsShowProfile(true)}
            >
              <Ionicons name='ios-person' color={'#F1E2A8'} size={32}></Ionicons>
            </TouchableOpacity>
          </View>

          {/* Services */}

          <View style={styles.containerServices}>
            <View style={styles.containerCardServices}>
              <TouchableOpacity style={styles.cardServices}
                onPress={() => setIsShowFuel(true)}
              >
                <Image style={styles.iconCardServices} source={require('../../../assets/combustivel-icon.png')}></Image>
              </TouchableOpacity>
              <Text style={styles.textCardServices}>Combustível</Text>
            </View>

            <View style={styles.containerCardServices}>
              <TouchableOpacity style={styles.cardServices}
                onPress={() => setIsShowParking(true)}
              >
                <Image style={styles.iconCardServices} source={require('../../../assets/estacionamento-icon.png')}></Image>
              </TouchableOpacity>
              <Text style={styles.textCardServices}>Estacionamento</Text>
            </View>

            <View style={styles.containerCardServices}>
              <TouchableOpacity style={styles.cardServices}
                onPress={() => setIsShowWash(true)}>
                <Image style={styles.iconCardServices} source={require('../../../assets/lavagem-icon.png')}></Image>
              </TouchableOpacity>
              <Text style={styles.textCardServices}>Lavagem</Text>
            </View>

          </View>

          {/* Monthly bill */}

          <View style={styles.cardMonthly}>

            {/* Geometric forms */}
            <View style={styles.monthlyCircle1}>
              <View style={styles.monthlyTriangle1}></View>
            </View>

            <View style={styles.monthlyCircle2}>
              <View style={styles.monthlyTriangle2}></View>
            </View>

            <View style={styles.monthlyCircle3}>
              <View style={styles.monthlyTriangle3}></View>
            </View>

            <View style={styles.monthlyTop}>
              <Text style={styles.monthlyTopText}>Conta Mensal</Text>
              <TouchableOpacity
                onPress={() => {
                  isBalanceVisible ? setIsBalanceVisible(false) : setIsBalanceVisible(true);
                }}
              >
                <Ionicons name={isBalanceVisible ? 'ios-eye-off' : 'ios-eye'} color={'#fff'} size={28}></Ionicons>
              </TouchableOpacity>
            </View>

            <View style={styles.containerMonthlyBalance}>
              <Text style={styles.monthlyBalanceLabel}>Extrato</Text>
              <Text style={styles.monthlyBalanceText}>R$ {isBalanceVisible ? '***,**' : '235,45'}</Text>
            </View>

            <TouchableOpacity style={styles.monthlyBtn}
              onPress={() => setIsShowExpenses(true)}
            >
              <Text style={styles.monthlyBtnText}>Ver detalhes</Text>
            </TouchableOpacity>
          </View>

          {/* Store */}

          <View style={styles.containerStore}>
            <View style={styles.storeHeader}>
              <Text style={styles.storeTitle}>Loja</Text>
              <TouchableOpacity style={styles.storeBtnShowMore}
                onPress={() => setIsShowStore(true)}
              >
                <Text style={styles.storeBtnShowMoreText}>Ver Mais</Text>
              </TouchableOpacity>
            </View>

            <View style={styles.containerProducts}>
              {
                listProducts.map((prod) => {
                  return (
                    <View style={styles.storeProduct} key={prod.id_produto}>
                      <Image
                        // source={{ uri: `file:///$prod.foto` }}
                        // onError={(error) => console.error('Erro ao carregar imagem:', error)}
                        // style={{ width: '100%', height: '100%' }}
                      />
                      <Text style={{ fontSize: 18 }}>{prod.nome_produto}</Text>

                      <TouchableOpacity
                        style={{
                          position: 'absolute',
                          width: '100%',
                          height: '100%'
                        }}
                        onPress={() => {
                          setProductNome(prod.nome_produto);
                          setProductId(prod.id_produto);
                          setProductDescription(prod.descricao_produto);
                          setProductPrice(prod.preco_produto);
                          setProductDiscount(prod.desconto);
                          setProductImage(prod.foto);
                          setIsShowProduct(true);
                        }}
                       
                      >
                      </TouchableOpacity>
                    </View>
                  );
                })
              }


            </View>
          </View>

          <View style={styles.containerUnits}>
            <Text style={styles.unitsHeadTitle}>Conheça as nossas unidades!</Text>
            {listGasStation.map((units) => (
              <View style={styles.unitCard} key={units.id_posto}>
                <Image source={require('../../../assets/point-icon.png')} style={styles.unityPointImg}></Image>
                <View style={styles.unitCardInfo}>
                  <Text style={styles.unitCardName}>{units.nome}</Text>
                  <Text style={styles.unitCardAddress}>{units.rua}, {units.bairro}, {units.numero}</Text>
                </View>
              </View>
            ))}
          </View>
        </View>
      </ScrollView >

      <View style={styles.navbar}>
        <TouchableOpacity style={styles.navbarHomebtn}>
          <Ionicons name='ios-home' color={'#258D5C'} size={30}></Ionicons>
        </TouchableOpacity>
        <TouchableOpacity style={styles.navbarHomebtn}
          onPress={() => setIsShowStore(true)}
        >
          <Image source={require('../../../assets/handbag-icon.png')} style={styles.navbarHomebtnIcon}></Image>
        </TouchableOpacity>
        <TouchableOpacity style={styles.navbarHomebtn}
          onPress={() => setIsShowExpenses(true)}
        >
          <Ionicons name='ios-card' color={'#6F6F6F'} size={30}></Ionicons>
        </TouchableOpacity>
        <TouchableOpacity style={styles.navbarHomebtn}
          onPress={() => setIsShowProfile(true)}
        >
          <Ionicons name='ios-person' color={'#6F6F6F'} size={30}></Ionicons>
        </TouchableOpacity>
      </View>
    </View >
  </>
}




