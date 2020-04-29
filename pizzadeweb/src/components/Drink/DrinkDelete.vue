<template>
    <div>
        <v-card id="deleteCard">
        <v-text-field v-model.number="DeleteDrink.id" label="Enter dish id"></v-text-field>
        <v-btn @click="removeDrink()">Slett rett</v-btn>
        </v-card>
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

<style lang="scss">
#deleteCard{
    background-color: #fff;
    flex: 0 0 auto; margin-right: 30%; margin-top: 20px; margin-left:30%;
    box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
    overflow: hidden;
}
</style>
