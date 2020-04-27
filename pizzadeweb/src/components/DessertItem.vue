<template>
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

<script>
export default {
    name: "DessertItem",
    props: {
        id:{
            type: Number
        },
        name:{
            type:String
        },
        ingredients: {
            type: String
        },
        price: {
            type: Number
        }
    }
}
</script>
