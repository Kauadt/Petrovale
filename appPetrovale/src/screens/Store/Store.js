import React, { useState, useEffect } from "react";
import { styles } from "./styles";
import { Text, View, Image, TouchableOpacity, TextInput, ScrollView, Modal, SafeAreaView } from 'react-native';
import axios from "axios";
import * as Animatable from 'react-native-animatable';
import { Ionicons } from '@expo/vector-icons';
import { StatusBar } from "expo-status-bar";
import { Profile } from "../Profile/Profile";
import { Expenses } from "../Expenses/Expenses";
import { Product } from "../Product/Product";
import apiUrl from "../apiConfig";

export const Store = ({ closeModalControls }) => {

  useEffect(() => {
    fetchData()
  }, [search])


  const [listProducts, setListProducts] = useState([]);
  const [search, setSearch] = useState('');


  const fetchData = () => {
    listProductsData()
  }

  async function listProductsData() {
    try {
      const res = await axios.get(apiUrl + 'listar.php?list=storeScreen&busca=' + search);
      if (Array.isArray(res.data.result)) {
        setListProducts(res.data.result);
      } else {
        setListProducts([]);
      }
    } catch (error) {
      console.error('Erro: ', error);
    }
  }

  const [isShowExpenses, setIsShowExpenses] = useState(false);
  const [isShowProfile, setIsShowProfile] = useState(false);

  const closeModalControlsStore = (modal) => {
    switch (modal) {
      case 'profile':
        setIsShowProfile(false)
        break;
      case 'expenses':
        setIsShowExpenses(false)
        break;
      default:
        return undefined
    }
  }

  const [isShowProduct, setIsShowProduct] = useState(false);
  const [productNome, setProductNome] = useState('');
  const [productId, setProductId] = useState('');
  const [productDescription, setProductDescription] = useState('');
  showItemsStore = () => {
    return [productNome, productId, productDescription];
  }

  const closeProductStore = () => {
    setIsShowProduct(false)
  }


  return <>

    <Modal
      visible={isShowProduct}
      transparent={false}
      animationType='slide'
      style={{ flex: 1, marginTop: 0 }}
    >
      <StatusBar hidden></StatusBar>
      <SafeAreaView style={{ flex: 1, marginTop: 0 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Product showItemsHome={showItemsStore} closeProduct={closeProductStore}></Product>
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
          <Expenses closeModalControls={closeModalControlsStore} closeModalControlsStore={closeModalControlsStore}></Expenses>
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
      <StatusBar></StatusBar>
      <SafeAreaView style={{ flex: 1 }}>
        <Animatable.View style={{ flex: 1 }}>
          <Profile closeModalControls={closeModalControlsStore} closeModalControlsStore={closeModalControlsStore}></Profile>
        </Animatable.View>
      </SafeAreaView>
    </Modal>

    <View style={styles.container}>
      <View style={styles.containerInputSearch}>

        {/* Não está funcionando */}
        <TextInput
          style={styles.inputSearch}
          placeholder='Pesquisar produtos'
          value={search}
          onChangeText={(search) => setSearch(search)}
          onChange={fetchData()}
        >
        </TextInput>
        <Ionicons
          style={styles.iconSearch}
          name="ios-search"
          size={25}
          color="#4b4a49"
        >
        </Ionicons>
      </View>

      <View style={styles.containerProduct}>
        <ScrollView>
          {listProducts.length === 0 ? (
            <Text>Produto não encontrado</Text>
          ) : (
            listProducts.map(prod => (
              <View key={prod.id_produto} style={styles.cardProduct}>
                <View style={styles.informationSide}>
                  <Text style={styles.nameProduct}>{prod.nome_produto}</Text>
                  <Text style={styles.descriptionProduct}>{prod.descricao_produto}</Text>
                  <View style={styles.containerPrice}>
                    <Text style={styles.priceProduct}>R$ {prod.preco_produto.replace('.', ',')}</Text>
                    <Text style={styles.discountProduct}>{(parseFloat(prod.desconto).toFixed(0)).replace('.', ',')} % OFF</Text>
                  </View>
                </View>
                <View style={styles.containerImg}>
                  <Ionicons name="image-outline" size={60} color={'#000'}></Ionicons>
                </View>
                <TouchableOpacity
                  style={{ width: '106%', height: '112%', position: 'absolute' }}
                  onPress={() => {
                    setProductNome(prod.nome_produto);
                    setProductId(prod.id_produto);
                    setProductDescription(prod.descricao_produto);
                    setIsShowProduct(true);
                  }}
                ></TouchableOpacity>
              </View>
            ))
          )}
        </ScrollView>
      </View>



      <View style={styles.navbar}>
        <TouchableOpacity style={styles.navbarHomebtn}
          onPress={() => closeModalControls('store')}
        >
          <Ionicons name='ios-home' color={'#6f6f6f'} size={30}></Ionicons>
        </TouchableOpacity>
        <TouchableOpacity style={styles.navbarHomebtn}>
          <Image source={require('../../../assets/greenHandBag-icon.png')} style={styles.navbarHomebtnIcon}></Image>
        </TouchableOpacity>
        <TouchableOpacity style={styles.navbarHomebtn}
          onPress={() => setIsShowExpenses(true)}
        >
          <Ionicons name='ios-card' color={'#6f6f6f'} size={30}></Ionicons>
        </TouchableOpacity>
        <TouchableOpacity style={styles.navbarHomebtn}
          onPress={() => setIsShowProfile(true)}
        >
          <Ionicons name='ios-person' color={'#6f6f6f'} size={30}></Ionicons>
        </TouchableOpacity>
      </View>
    </View>
  </>
}   