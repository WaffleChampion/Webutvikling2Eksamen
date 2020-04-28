<template>
    <div>
        <v-col cols="12" sm="6" lg="4" class="mx-auto">
        <v-text-field v-model.number="EditDish.id" label="Enter dish id"></v-text-field>
        <v-btn @click="getDish()">Hent rett</v-btn>
        
        
                <v-text-field v-model="EditDish.dishType"></v-text-field>
                <v-text-field v-model="EditDish.dishName"></v-text-field>
                <v-text-field v-model="EditDish.ingredients" ></v-text-field>
                <v-text-field v-model="EditDish.vegetarian" ></v-text-field>
                <v-text-field v-model="EditDish.allergens" ></v-text-field>
                <v-text-field v-model.number="EditDish.price" type="number" ></v-text-field>
                <v-text-field v-model="EditDish.file" show-size></v-text-field>
             <v-btn @click="editDish()">Endre rett</v-btn>
            
       
        </v-col>
        <DishList/>
    </div>
</template>
<script>
    import axios from 'axios'
    import DishList from "@/components/Dish/DishList.vue"
    export default {
        name: "DishEdit",
        data(){
            return{
                EditDish:{},
                items: [`type`, `navn`, `ingredienser`, `vegetar`, `allergener`, `pris`],
                file:null
            }
        },
        methods:{
            //Method to get the specific object from the data base and fill the text fields with the info
            getDish(){
                console.log(this.EditDish.id)
                axios.get(`https://localhost:5001/meny/${this.EditDish.id}`).then( result => {
                        console.log( result.data );
                        this.EditDish.dishType=result.data.dishType
                        this.EditDish.dishName=result.data.dishName
                        this.EditDish.ingredients=result.data.ingredients
                        this.EditDish.vegetarian=result.data.vegetarian
                        this.EditDish.allergens=result.data.allergens
                        this.EditDish.price=result.data.price
                        this.EditDish.file=result.data.imageSrc
                        console.log(result.data.dishType)
                        this.$forceUpdate();
                })
            },
            //Method to change the data in the database with the info in the text fields
            editDish(){
                let obj= {
                    id: this.EditDish.id,
                    dishType: this.EditDish.dishType,
                    dishName: this.EditDish.dishName,
                    ingredients: this.EditDish.ingredients,
                    vegetarian: this.EditDish.vegetarian,
                    allergens: this.EditDish.allergens,
                    price: this.EditDish.price,
                    imageSrc: this.EditDish.file}
                    console.log(obj)

                    axios.put(`https://localhost:5001/meny`, obj).then( result => {
                        console.log( result.data );
                        })
                }

        },
        components: {
            DishList
        }
    }
</script>