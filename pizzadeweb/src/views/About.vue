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

.about{

  background: url('../components/images/Frontpage/pizzabackground.jpg');
  height: 100%;
  /*width: 100%;*/
  background-position: center;
  background-size: cover;
}
</style>
