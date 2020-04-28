<template>
    <div id="nav">
      <div>
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
      </div>
      <div>
        <router-link to="/dishes">Retter</router-link> |
        <router-link to="/drinks">Drikke</router-link> |
        <router-link to="/dessert">Dessert</router-link>|
      </div>
    <DishList/>
    </div>
</template>

<script>

import DishList from '@/components/DishList.vue'
export default {
name: 'Meny',
  components: {
    DishList,
    
  }
}
</script>