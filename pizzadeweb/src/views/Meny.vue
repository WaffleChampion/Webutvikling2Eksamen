<template>
    <div class="background">
      <div>
        <router-link to="/dishes">Retter</router-link> |
        <router-link to="/drinks">Drikke</router-link> |
        <router-link to="/dessert">Dessert</router-link>|
      </div>
    <DishList/>
    </div>
</template>

<script>

import DishList from '@/components/Dish/DishList.vue'
export default {
name: 'Meny',
  components: {
    DishList,
    
  }
}
</script>

<style lang="scss">
.background{
  background: url('../components/images/Frontpage/pizzabackground.jpg');
  height: 100%;
  /*width: 100%;*/
  background-position: center;
  background-size: cover;


}
</style>