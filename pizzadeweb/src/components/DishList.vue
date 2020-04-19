<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" v-for="dish in dishes" :key="dish.id">
                <DishItem 
                    :id="dish.id"
                    :type="dish.dishType" 
                    :name="dish.dishName" 
                    :ingredients="dish.ingredients"
                    :vegetarian="dish.vegetarian"  
                    :allergens="dish.allergens"
                    :price="dish.price"
                    :imageSrc="dish.imageSrc" />

            </v-col>
        </v-row>
    </div>
</template>
<script>
import axios from 'axios'
import DishItem from '@/components/DishItem'
export default {
    name: "DishList",
    data(){
        return {
            dishes:[ { 
                id: 1, type: "Pizza", name: "Hawaii", ingredients: "Ananas, skinke, ost, tomatsaus", vegetarian: "false", allergens: "gluten, laktose", price: 179, imageSrc: "pizzahawaii.jpg"
            } ]
        }
    },
    created(){
        axios.get("https://localhost:5001/Meny")
            .then( result => {
                this.dishes = result.data;
            } )
    },
    components: {
        DishItem
    }
}
</script>
