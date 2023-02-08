<template>
    <div class="background">
        <div id="nav">
            <router-link to="/dishes"><v-btn>Retter</v-btn></router-link> 
           
            <router-link to="/drinks"><v-btn>Drikke</v-btn></router-link> 
            
            <router-link to="/dessert"><v-btn>Dessert</v-btn></router-link>
        </div>
        <h1>Alle Drikker</h1>
        <DrinkList />

    </div>
</template>

<script>
import DrinkList from '@/components/Drink/DrinkList.vue'
export default {
    name:"Drinks",
    components: {
        DrinkList
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
  margin: 3px;
}
</style>
