<template>
    <div>
        <v-text-field v-model.number="DeleteDish.id" label="Enter dish id"></v-text-field>
        <v-btn @click="removeDish()">Slett rett</v-btn>
        <v-col cols="12" sm="6" lg="4" class="mx-auto">
            <DishList />
        </v-col>
    </div>
</template>
<script>
import axios from 'axios'
import DishList from "@/components/DishList.vue"
export default {
    name: "DishDelete",
    data(){
        return{

            DeleteDish:{id: 1},
            file:null
        }
    },
    methods:{

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