<template>
    <div>
        <v-card id="deleteCard">
        <v-text-field v-model.number="DeleteDish.id" label="Enter dish id"></v-text-field>
        <v-btn @click="removeDish()">Slett rett</v-btn>
        </v-card>
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

<style lang="scss">
#deleteCard{
    background-color: #fff;
    flex: 0 0 auto; margin-right: 30%; margin-top: 20px; margin-left:30%;
    box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
    overflow: hidden;
}
</style>