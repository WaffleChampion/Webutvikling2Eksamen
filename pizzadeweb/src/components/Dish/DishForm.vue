<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="mx-auto">
                <v-text-field v-model="newDish.dishType" label="Type rett"></v-text-field>
                <v-text-field v-model="newDish.dishName" label="Navn på rett"></v-text-field>
                <v-text-field v-model="newDish.ingredients" label="legg til ingredienser"></v-text-field>
                <v-text-field v-model="newDish.vegetarian" label="vegetar?"></v-text-field>
                <v-text-field v-model="newDish.allergens" label="legg til allergener"></v-text-field>
                <v-text-field v-model.number="newDish.price" type="number" label="legg til pris"></v-text-field>
                <v-file-input v-model="file" show-size></v-file-input>
                <v-btn @click="postDish">Lagre ny rett</v-btn>
            </v-col>
        </v-row>
    </div>
</template>
<script>
import axios from 'axios'
export default {
    name: "DishForm",
    data(){
        return {
            newDish: { dishType: "", dishName: "", ingredients: "", allergens:"",  imageSrc: "" },
            file: null
        }
    },
    methods: {
        //Method to create a new entry in the database with the info in the text fields
        postDish(){
            this.newDish.imageSrc = this.newDish.dishName+".jpg";

            let data = new FormData();
            data.append("file", this.file);

            axios.post("https://localhost:5001/meny", this.newDish).then( result => {
                    console.log( result.data );

                    axios({
                        method: "POST",
                        url: "https://localhost:5001/menyadmin/uploadimage",
                        data: data,
                        config: { headers: { 'Content-Type': 'multipart/form-data' } }       
                    })

                } )
        }
    }
}
</script>