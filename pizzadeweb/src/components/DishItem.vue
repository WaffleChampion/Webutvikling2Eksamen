<template>
    <v-card>
        <v-card-title>{{ dishType }}</v-card-title>
        <v-card-title>{{ dishName }}</v-card-title>
        <v-card-title>{{ ingredients }}</v-card-title>
        <v-card-title>{{ vegetarian }}</v-card-title>
        <v-card-title>{{ allergens }}</v-card-title>
        <v-card-title>{{ price }}</v-card-title>
    </v-card>
</template>

<script>
export default {
    name: "DishItem",
    props: {
        dishType: {
            type: String
        },
        dishName: {
            type: String
        },
        ingredients: {
            type: String
        },
        vegetarian: {
            type: Boolean
        },
        allergens: {
            type: String
        },
        price: {
            type: Number
        }

    }
}
</script>