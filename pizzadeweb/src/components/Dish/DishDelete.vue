<template>
    <div>
        <v-text-field v-model.number="DeleteDish.id" label="Enter dish id"></v-text-field>
        <v-btn @click="removeDish()">Slett rett</v-btn>
        <DishList />
    </div>
</template>

<script>
    import axios from 'axios'
    import DishList from "@/components/Dish/DishList.vue"
    export default {
        name: "DishDelete",
        data(){
            return{

                DeleteDish:{},
                file:null
            }
        },
        methods:{
            //Method to remove an entry from the database with the defined ID
            removeDish(){
                axios.delete(`https://localhost:5001/meny/${this.DeleteDish.id}`)
                .then( result => {
                    console.log(result.data)
                })
            },
    
        },
        components: {
        DishList
        }
    }
</script>