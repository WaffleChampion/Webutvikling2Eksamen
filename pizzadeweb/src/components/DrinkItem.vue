<template>
  <v-card>
      <v-card-title>{{ type }}</v-card-title>
        <v-img
        :src="`https://localhost:5001/images/Drinks/${imageSrc}`"
        height= "200px"
        width="100px">
        </v-img>
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
        },
        imageSrc:{
            type:String
        }
    }
}
</script>
