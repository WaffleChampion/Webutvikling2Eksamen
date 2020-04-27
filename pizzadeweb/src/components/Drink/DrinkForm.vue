<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" class="mx-auto">
                <v-text-field v-model="newDrink.type" label="Navn på rett"></v-text-field>

                <v-text-field v-model.number="newDrink.price" type="number" label="legg til pris"></v-text-field>
                <v-file-input v-model="file" show-size></v-file-input>
                <v-btn @click="postDish">Lagre ny rett</v-btn>
            </v-col>
        </v-row>
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

                } )
        }
    }
}
</script>