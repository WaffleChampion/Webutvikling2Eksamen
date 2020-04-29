<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
        <div id="nav">
            <router-link to="/adddish">Legg til</router-link> |
            <router-link to="/deletedish">Fjern</router-link> |
            <router-link to="/editdish">Rediger rett</router-link> |
        </div>
    <DishList/>
    </div>
</template>

<script>
import DishList from '@/components/Dish/DishList.vue'
export default {
    name: "DishAdmin",
    components: {
        DishList
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

#nav a{ 
  color: #ffffff;
  text-decoration: none;
  list-style-type: none;
  text-align: center;
}
</style>