<template>
  <v-card>
        <v-card-title>{{ id }}</v-card-title>
        <v-card-title>Navn: {{ name }}</v-card-title>
        <v-card-title>Beskrivelse: {{ Description }}</v-card-title>
        <v-img
        :src="`https://localhost:5001/images/${imageSrc}`"
        height= "200px"
        width="100px">
        </v-img>
      <v-card-title>Pris: {{ price }}Kr</v-card-title>

  </v-card>
</template>
<script>
export default {
    name: "DessertItem",
    props: {
        id:{
            type:Number
        },
        name:{
            
            type: String
        },
        Description:{
            type: String
        },
        imageSrc:{
            type:String
        },
        price:{
            type: Number
        }
    }
}
</script>
