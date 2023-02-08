<template>

<div class="about">
  <!-- Putter in bilde -->
    <v-container>
    <v-row justify="space-around">
      <v-col cols="5">
        <v-img src="https://images.squarespace-cdn.com/content/v1/5d9df6a0e4618a005f10d9ae/1573740806427-NOSL3CVM08PJ5GC6A4DA/ke17ZwdGBToddI8pDm48kLkXF2pIyv_F2eUT9F60jBl7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0iyqMbMesKd95J-X4EagrgU9L3Sa3U8cogeb0tjXbfawd0urKshkc5MgdBeJmALQKw/code1IMG_2003.jpg" aspect-ratio="1.7"></v-img>
       </v-col>
    </v-row>  
    <!-- puter texten in i nettsiden fra Textstore -->
    </v-container>
    <ul>
      <li v-for="Text in texts" :key="Text.id">
          {{Text.info}}
      </li >
    </ul>
  </div>

</template>

<script>
// henter texten fra TextStore og lar li taggen over displaye det
import TextStore from '@/stores/TextStore.js'
export default {
  name: "About",
  data(){
    return {
      texts: TextStore.getTexts()
    }
  }
}


</script>

<style>
.about{
  background: url('../components/images/Frontpage/pizzabackground.jpg');
  height: 100%;
  background-position: center;
  background-size: cover;
}
</style>
