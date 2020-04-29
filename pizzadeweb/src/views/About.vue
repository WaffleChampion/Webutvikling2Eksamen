<template>

  <div class="about">
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
  background-position: center;
  background-size: cover;
}
</style>
