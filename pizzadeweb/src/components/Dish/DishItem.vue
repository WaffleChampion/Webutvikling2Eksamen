<template>
    <v-card>
        <v-card-title>{{ id }}</v-card-title>
        <v-card-title>Type rett: {{ type }}</v-card-title>
        <v-card-title>Navn på rett: {{ name }}</v-card-title>
        <v-card-title>Ingredienser: {{ ingredients }}</v-card-title>
        <v-card-title>Vegetar: {{ vegetarian }}</v-card-title>
        <v-card-title>Allergener: {{ allergens }}</v-card-title>
        <v-card-title>Pris: {{ price }}kr</v-card-title>
        <v-img
            :src="`https://localhost:5001/images/${imageSrc}`"
            height="300px"
            width="100%">
        </v-img>
    </v-card>
</template>

<script>
    export default {
        name: "DishItem",
        props: {
            id:{
                type: Number
            },
            type: {
                type: String
            },
            name:{
                type:String
            },
            ingredients: {
                type: String
            },
            vegetarian: {
                type: String
            },
            allergens: {
                type: String
            },
            price: {
                type: Number
            },
            imageSrc: {
                type: String
            }

        }
    }
</script>