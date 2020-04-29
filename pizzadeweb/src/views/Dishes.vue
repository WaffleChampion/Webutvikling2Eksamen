<template>
<<<<<<< Updated upstream
    <div>
              <div>
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
      </div>
        <div>
            <router-link to="/dishes">Retter</router-link> |
            <router-link to="/drinks">Drikke</router-link> |
            <router-link to="/dessert">Dessert</router-link>|
=======
    <div class="background">
        <div id="nav">
            <router-link to="/dishes"><v-btn>Retter</v-btn></router-link> 
           
            <router-link to="/drinks"><v-btn>Drikke</v-btn></router-link> 
            
            <router-link to="/dessert"><v-btn>Dessert</v-btn></router-link>
            
>>>>>>> Stashed changes
        </div>
        <h1>Alle Retter</h1>
        <DishList />

    </div>
</template>

<script>
import DishList from '@/components/Dish/DishList.vue'
export default {
    name:"Dishes",
    components: {
        DishList
    }
}
<<<<<<< Updated upstream
</script>
=======
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
  margin: 3px;
}
</style>
>>>>>>> Stashed changes
