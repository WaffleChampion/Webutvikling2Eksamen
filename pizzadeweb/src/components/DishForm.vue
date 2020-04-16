<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="mx-auto">
                <v-text-field v-model="newDish.dishType" label="Type rett"></v-text-field>
                <v-text-field v-model="newDish.dishName" label="Navn på rett"></v-text-field>
                <v-text-field v-model="newDish.ingredients" label="legg til ingredienser"></v-text-field>
                <v-text-field v-model="newDish.vegetarian" label="legg til om den er vegetar"></v-text-field>
                <v-text-field v-model="newDish.allergens" label="legg til allergener"></v-text-field>
                <v-text-field v-model="newDish.price" label="legg til pris"></v-text-field>
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
            newDish: { dishType: "", dishName: "", ingredients: "", vegetarian:"", allergens:"", price:"", imageSrc: "" },
            file: null
        }
    },
    methods: {
        postDish(){
            this.newDish.imageSrc = this.file.dishName;

            let data = new FormData();
            data.append("file", this.file);

            axios.post("https://localhost:5001/ManyAdmin", this.newDish)
                .then( result => {
                    console.log( result.data );

                    axios({
                        method: "POST",
                        url: "https://localhost:5001/ManyAdmin/UploadImage",
                        data: data,
                        config: { headers: { 'Content-Type': 'multipart/form-data' } }       
                    })

                } )
        }
    }
}
</script>