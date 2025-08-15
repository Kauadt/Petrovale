import React, { useState } from 'react';
import { View, Text, Pressable, StyleSheet, ScrollView } from 'react-native';


export const VacancyRadio = ({ vacancies, onSelect, onVacancySelect }) => {

  const [userVacancy, setUserVacancy] = useState(null);


  const selectHandler = (value) => {
    onSelect(value);
    setUserVacancy(value);
  };

  const vacancyHandler = (value) => {
    onVacancySelect(value);
  };

  return (
    <View style={{ flex: 0.8 }}>
      <ScrollView nestedScrollEnabled={true} horizontal={true}>
        <View style={styles.vacancyArea}>
          {vacancies.map((item) => {
            if (item.status == 'Vago') {
              return (
                <Pressable
                  key={item.idVacancy}
                  style={
                    item.numVacancy === userVacancy ? styles.selected : styles.unselected
                  }
                  onPress={() => {
                    selectHandler(item.numVacancy)
                    vacancyHandler(item.idVacancy)
                  }}>
                  <Text style={styles.option}> {item.numVacancy}</Text>
                </Pressable>
              );
            }
          })}
        </View>
      </ScrollView>
    </View>
  );
}

const styles = StyleSheet.create({
  option: {
    fontSize: 16,
    color: '#000',
    width: '100%',
    textAlign: 'center',
    paddingRight: 3
  },
  unselected: {
    width: 42,
    height: 42,
    borderRadius: 100,
    alignItems: 'center',
    justifyContent: 'center',
  },

  selected: {
    width: 42,
    height: 42,
    backgroundColor: '#7DB132',
    borderRadius: 100,
    alignItems: 'center',
    justifyContent: 'center',
  },

  vacancyArea: {
    maxHeight: 270,
    padding: 10,
    flexDirection: 'column',
    flexWrap: 'wrap',
    gap: 5,
    paddingBottom: 20,
  },
});