<template>
    <div>
        <v-row>
            <v-col cols="12" sm= "6" ig="4" v-for="drink in drinks" :key="drink.id">
                <DrinkItem 
                :id="drink.id"
                :type="drink.type"
                :price="drink.price"
                :imageSrc="drink.imageSrc" />
                
                

            </v-col>

        </v-row>
</div>
</template>
<script>
import axios from 'axios'
import DrinkItem from '@/components/DrinkItem.vue'

export default {
    name: "DrinkList",
    data(){
        return{
            drinks:[{id:1, type: "Coca Cola", price: 37}]
        }


    },
    created(){
            axios.get("https://localhost:5001/Drink")
            .then( result =>{
                this.drinks = result.data;
            }


            )},
        
        components: {
            DrinkItem
        }
        }
        

</script>