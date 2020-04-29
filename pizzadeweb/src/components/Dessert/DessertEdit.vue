<template>

    <div>
        <v-card id="editCard">
        <v-col cols="12" sm="6" lg="4" class="mx-auto">
        <v-text-field v-model.number="EditDessert.id" label="Enter dish id"></v-text-field>
        <v-btn @click="getDessert()">Hent rett</v-btn>
        
        
                <v-text-field v-model="EditDessert.name"></v-text-field>
                <v-text-field v-model="EditDessert.description"></v-text-field>
                <v-text-field v-model.number="EditDessert.price" type="number" ></v-text-field>
                <v-text-field v-model="EditDessert.imageSrc"></v-text-field>
             <v-btn @click="editDessert()">Endre rett</v-btn>
            
            <v-text-field v-model="EditDessert.DessertName"></v-text-field>
            <v-text-field v-model="EditDessert.description"></v-text-field>
            <v-text-field v-model.number="EditDessert.price" type="number" ></v-text-field>
            <v-text-field v-model="EditDessert.imageSrc"></v-text-field>
            <v-btn @click="editDessert()">Endre rett</v-btn>
        </v-col>
        </v-card>
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
            //Method to get the specific object from the data base and fill the text fields with the info
            getDessert(){
                console.log(this.EditDessert.id)
                axios.get(`https://localhost:5001/desserts/${this.EditDessert.id}`).then( result => {
                        console.log( result.data );

                        this.EditDessert.name=result.data.name
                        this.EditDessert.description=result.data.description
                        this.EditDessert.price=result.data.price
                        this.EditDessert.imageSrc=result.data.imageSrc
                        this.$forceUpdate();
                })
            },

            //Method to change the data in the database with the info in the text fields
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

<style lang="scss">
#editCard{ 
    background-color: #fff;
    flex: 0 0 auto; margin-right: 30%; margin-top: 20px; margin-left:30%;
    box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
    overflow: hidden;
}
</style>