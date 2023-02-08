<template>

    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" v-for="dish in dishes" :key="dish.id" >
                <v-card id="dishCard">
                    <DishItem 
                        :id="dish.id"
                        :type="dish.dishType" 
                        :name="dish.dishName" 
                        :ingredients="dish.ingredients"
                        :vegetarian="dish.vegetarian"  
                        :allergens="dish.allergens"
                        :price="dish.price"
                        :imageSrc="dish.imageSrc" />
                </v-card>
            </v-col>
        </v-row>
        
    </div>
    
</template>
<script>
    import axios from 'axios'
    import DishItem from '@/components/Dish/DishItem'
    export default {
        name: "DishList",
        data(){
            return {
                dishes:[ { 
                    id: 1, type: "Pizza", name: "Hawaii", ingredients: "Ananas, skinke, ost, tomatsaus", vegetarian: "false", allergens: "gluten, laktose", price: 179, imageSrc: "pizzahawaii.jpg"
                } ]
            }
        },
        //Creates cards with info from the database when the page is loaded
        created(){
            axios.get("https://localhost:5001/Meny")
                .then( result => {
                    this.dishes = result.data;
                })
        },
        components: {
            DishItem
        }
    }
</script>

<style lang="scss">
#dishCard{
    box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
  flex: 0 0 50%;  margin-top: 20px; margin-left:10%; margin-right: 10%;
}
</style>
