<template>
    <div>
        <v-col cols="12" sm="6" lg="4" class="mx-auto">
        <v-text-field v-model.number="EditDessert.id" label="Enter dish id"></v-text-field>
        <v-btn @click="getDessert()">Hent rett</v-btn>
        
        
                <v-text-field v-model="EditDessert.DessertName"></v-text-field>
                <v-text-field v-model="EditDessert.description"></v-text-field>
                <v-text-field v-model.number="EditDessert.price" type="number" ></v-text-field>
                <v-text-field v-model="EditDessert.imageSrc"></v-text-field>
             <v-btn @click="editDessert()">Endre rett</v-btn>
            
       
        </v-col>
        <DessertList/>
    </div>
</template>
<script>
import axios from 'axios'
import DessertList from "@/components/Dessert/DessertList.vue"
export default {
    name: "DessertEdit",
    data(){
        return{
            EditDessert:{},
            file:null
        }
    },
    methods:{
        getDessert(){
            console.log(this.EditDessert.id)
            axios.get(`https://localhost:5001/meny/${this.EditDessert.id}`).then( result => {
                    console.log( result.data );

                    this.EditDessert.dessertName=result.data.dessertName
                    this.EditDessert.description=result.data.description
                    this.EditDessert.price=result.data.price
                    this.EditDessert.imageSrc=result.data.imageSrc
                    this.$forceUpdate();
            })
        },
        editDessert(){
            let obj= {
                id: this.EditDessert.id,
                dessertName: this.EditDessert.dessertName,
                description: this.EditDessert.description,
                price: this.EditDessert.price,
                imageSrc: this.EditDessert.imageSrc}
                console.log(obj)

                axios.put(`https://localhost:5001/dessert`, obj).then( result => {
                    console.log( result.data );})
        }

    },
    components: {
        DessertList
    }
}
</script>