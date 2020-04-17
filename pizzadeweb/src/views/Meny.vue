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
    </div>
</template>

<script>

//import DrinkList from '@/components/DrinkList.vue'
export default {
name: 'Meny',
  //components: {
    //DishList,
    //DrinkList
  //}
}
</script>