<template>

    <div>
        <v-text-field v-model.number="DeleteDessert.id" label="Enter dish id"></v-text-field>
        <v-btn @click="removeDessert()">Slett rett</v-btn>
        <v-col cols="12" sm="6" lg="4" class="mx-auto">
            <DessertList />
        </v-col>
    </div>

</template>
<script>
    import axios from 'axios'
    import DessertList from "@/components/Dessert/DessertList.vue"
    export default {
        name: "DishDelete",
        data(){
            return{

                DeleteDessert:{id: 1},
                file:null
            }
        },

        methods:{
            //Method to remove an entry from the database with the defined ID
            removeDessert(){
                axios.delete(`https://localhost:5001/meny/${this.DeleteDessert.id}`)
                .then( result => {
                    console.log(result.data)
                })
            },
    
        },
            
        components: {
            DessertList
        }
    }
</script>