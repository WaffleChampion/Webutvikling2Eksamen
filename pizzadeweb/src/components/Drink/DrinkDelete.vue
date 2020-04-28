<template>
    <div>
        <v-text-field v-model.number="DeleteDrink.id" label="Enter dish id"></v-text-field>
        <v-btn @click="removeDrink()">Slett rett</v-btn>
        <v-col cols="12" sm="6" lg="4" class="mx-auto">
            <DrinkList />
        </v-col>
    </div>
</template>
<script>
import axios from 'axios'
import DrinkList from "@/components/Drink/DrinkList.vue"
export default {
    name: "DrinkDelete",
    data(){
        return{

            DeleteDrink:{id: 1},
            file:null
        }
    },
    methods:{
        //Method to remove an entry from the database with the defined ID
        removeDrink(){
            axios.delete(`https://localhost:5001/drink/${this.DeleteDrink.id}`)
            .then( result => {
                console.log(result.data)
            })
},
 
    },
        
    
    components: {
        DrinkList
    }
}
</script>
