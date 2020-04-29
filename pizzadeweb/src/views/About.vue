<template>



  
  <div class="about">
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
#app {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background: url(https://image.freepik.com/free-photo/slice-delicious-pizza-with-ingredients-textured-wooden-background_23-2147926094.jpg) no-repeat center center fixed;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
.about{
  color: goldenrod;
}
</style>
