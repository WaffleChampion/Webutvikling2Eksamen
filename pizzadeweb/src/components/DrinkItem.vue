<template>
  <v-card>
      <v-img></v-img>
      <v-card-title>{{ type }}</v-card-title>
      <v-card-title>{{ price }}</v-card-title>
  </v-card>
</template>
<script>
export default {
    name: "DrinkItem",
    props: {
        type:{
            
            type: String
        },
        price:{
            type: Number
        }
    }
}
</script>
