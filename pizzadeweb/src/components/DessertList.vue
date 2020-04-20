<template>
<div>
    <v-row>
        <v-col cols="12" sm="6" lg="4" v-for="dessert in dessertes" :key="dessert.id">
            <DessertItem
            :id="dessert.id"
            :name="dessert.name"
            :Description="dessert.description"
            :price="dessert.price"/>

        </v-col>
|   </v-row>
</div>
    
</template>

<script>
import axios from 'axios'
import DessertItem from '@/components/DessertItem.vue'
export default {
    name: "DessertList",
    data(){
        return {
            dessertes: [ {
                id: 1, name: "OreoKake", description: "Oreo, Vanilje, Egg", price: 70
            } ]
        }
    },
    created(){
        console.log("working")
        axios.get("https://localhost:5001/Desserts").then( result => {
            console.log(result.data)
            this.dessertes = result.data;

        } )
    },
    components: {
        DessertItem
    }
}
</script>

