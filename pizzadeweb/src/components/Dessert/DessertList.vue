<template>
<div>
    <v-row>
        <v-col cols="12" sm="6" lg="4" v-for="dessert in dessertes" :key="dessert.id">
            <v-card id="dessertCard">
            <DessertItem
            :id="dessert.id"
            :name="dessert.name"
            :Description="dessert.description"
            :imageSrc="dessert.imageSrc"
            :price="dessert.price"/>
            </v-card>

        </v-col>
|   </v-row>
</div>
    
</template>

<script>
    import axios from 'axios'
    import DessertItem from '@/components/Dessert/DessertItem.vue'
    export default {
        name: "DessertList",
        data(){
            return {
                dessertes: [{
                    id: 1, name: "OreoKake", description: "Oreo, Vanilje, Egg", price: 70
                }]
            }
        },
        
        created(){
            //Creates cards with info from the database when the page is loaded
            axios.get("https://localhost:5001/Desserts").then( result => {
                console.log(result.data)
                this.dessertes = result.data;

            })
        },
        components: {
            DessertItem
        }
    }
</script>

<style lang="scss">
#dessertCard{
    box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
  flex: 0 0 50%;  margin-top: 20px; margin-left:10%; margin-right: 10%;
}
</style>

