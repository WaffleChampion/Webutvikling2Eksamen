<template>
<<<<<<< HEAD
    <v-card>
        <v-card-title>{{ id }}</v-card-title>
        <v-card-title>Navn på rett: {{ name }}</v-card-title>
        <v-card-title>Ingredienser: {{ ingredients }}</v-card-title>
        <v-card-title>Pris: {{ price }}kr</v-card-title>
        <v-img
            :src="`https://localhost:5001/images/Desserts/${imageSrc}`"
            height="200px"
            width="400px">
        </v-img>
    </v-card>
</template>

=======
  <v-card>
        <v-card-title>{{ id }}</v-card-title>
        <v-card-title>Navn: {{ name }}</v-card-title>
        <v-card-title>Beskrivelse: {{ Description }}</v-card-title>
        <!--<v-img
        :src="`https://localhost:5001/images/Dessert/${imageSrc}`"
        height= "200px"
        width="100px">
        </v-img>-->
      <v-card-title>Pris: {{ price }}Kr</v-card-title>

  </v-card>
</template>
>>>>>>> e5aa79bf4f563e2d552ac4b9a45b8691c715b529
<script>
export default {
    name: "DessertItem",
    props: {
        id:{
<<<<<<< HEAD
            type: Number
        },
        name:{
            type:String
        },
        ingredients: {
            type: String
        },
        price: {
=======
            type:Number
        },
        name:{
            
            type: String
        },
        Description:{
            type: String
        },
        //imageSrc:{
            //type:String
        //},
        price:{
>>>>>>> e5aa79bf4f563e2d552ac4b9a45b8691c715b529
            type: Number
        }
    }
}
</script>
