<template>
    <div>
        <v-row>
            <v-col cols="12" sm= "6" ig="4" v-for="drink in drinks" :key="drink.id">
                <v-card id="drinkCard">
                <DrinkItem 
                :id="drink.id"
                :type="drink.type"
                :price="drink.price"
                :imageSrc="drink.imageSrc" />
                </v-card>
                

            </v-col>

        </v-row>
</div>
</template>

<script>
import axios from 'axios'
import DrinkItem from '@/components/Drink/DrinkItem.vue'

export default {
    name: "DrinkList",
    data(){
        return{
            drinks:[{id:1, type: "Coca Cola", price: 37}]
        }


    },
    //Creates cards with info from the database when the page is loaded
    created(){
        axios.get("https://localhost:5001/Drink")
        .then( result =>{
            this.drinks = result.data;
        })
    },     
    components: {
        DrinkItem
    }
}
        

</script>

<style lang="scss">
#drinkCard{
    box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
  flex: 0 0 50%;  margin-top: 20px; margin-left:10%; margin-right: 10%;
}
</style>