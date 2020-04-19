<template>
<div>
    <v-row>
        <v-col cols="12" sm="6" lg="4" v-for="dessert in dessertes" :key="dessert.id">
            <dessertItem
            :id="dessert.id"
            :type="dessert.dessertType"
            :name="dessert.DessertName"
            :ingredients="dessert.ingredients"
            :price="dessert.price"/>

        </v-col>
|   </v-row>
</div>
    
</template>

<script>
import axios from 'axios'
import dessertItem from '@/components/DessertItem'
export default {
    name: "DessertList",
    data(){
        return {
            dessertes: [ {
                id: 1, type: "Cake", name: "OreoKake", ingredients: "Oreo, Vanilje, Egg", price: 70,
            } ]
        }
    },
    created(){
        axios.get("https://localhost:5001/meny")
        .then( result => {
            this.dessertes = result.data;
        } )
    },
    components: {
        DessertItem
    }
}
</script>

