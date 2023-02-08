<template>
    <div>
        <v-card id="addCard">
            <v-row>
                <v-col cols="12" sm="6" lg="4" class="mx-auto">
                    <v-text-field v-model="newDrink.type" label="Navn på rett"></v-text-field>

                    <v-text-field v-model.number="newDrink.price" type="number" label="legg til pris"></v-text-field>
                    <v-file-input v-model="file" show-size></v-file-input>
                    <v-btn @click="postDish">Lagre ny rett</v-btn>
                </v-col>
            </v-row>
        </v-card>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    name: "DrinkForm",
    data(){
        return {
            newDrink: { type: "",  imageSrc: "" },
            file: null
        }
    },
    methods: {
        //Method to create a new entry in the database with the info in the text fields
        postDish(){
            this.newDrink.imageSrc = this.newDrink.type+".jpg";

            let data = new FormData();
            data.append("file", this.file);

            axios.post("https://localhost:5001/Drink", this.newDrink).then( result => {
                    console.log( result.data );

                    axios({
                        method: "POST",
                        url: "https://localhost:5001/menyadmin/uploadimage",
                        data: data,
                        config: { headers: { 'Content-Type': 'multipart/form-data' } }       
                    })

            })
        }
    }
}
</script>

<style lang="scss">
#addCard{ 
    
    background-color: #fff;
    flex: 0 0 auto; margin-right: 30%; margin-top: 20px; margin-left:30%;
    box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
    overflow: hidden;

}
</style>