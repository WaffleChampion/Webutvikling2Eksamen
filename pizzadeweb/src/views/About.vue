<template>


<div class="about">
    <v-container>
    <v-row justify="space-around">
      <v-col cols="5">
        <v-img src="https://images.squarespace-cdn.com/content/v1/5d9df6a0e4618a005f10d9ae/1573740806427-NOSL3CVM08PJ5GC6A4DA/ke17ZwdGBToddI8pDm48kLkXF2pIyv_F2eUT9F60jBl7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0iyqMbMesKd95J-X4EagrgU9L3Sa3U8cogeb0tjXbfawd0urKshkc5MgdBeJmALQKw/code1IMG_2003.jpg" aspect-ratio="1.7"></v-img>
       </v-col>
    </v-row>  
    </v-container>
    <!--
    <h1>PizzaDeWeb</h1>
    <h2> Lorem ipsum dolor sit amet, consectetuer adipiscing elit. 
      Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient 
      montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, se
      m. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet 
      nec, vulputate eget, arcu. In enim justo, rhoncus ut,
    </h2>'
    <h2>
      Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient 
      montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, se
      m. Nulla consequat massa quis enim.

    </h2>

    <h2>
      Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient 
      montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, se
      m. Nulla consequat massa quis enim.
    </h2>-->
    <ul>
    <li v-for="Text in texts" :key="Text.id">
        {{Text.info}}
    </li >
    </ul>
  </div>


</template>

<script>

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
  /*width: 100%;*/
  background-position: center;
  background-size: cover;
}
</style>
