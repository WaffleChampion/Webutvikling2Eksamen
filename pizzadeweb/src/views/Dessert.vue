<template>
    <div class="background">
        <div id="nav">
            <router-link to="/dishes"><v-btn>Retter</v-btn></router-link> 
           
            <router-link to="/drinks"><v-btn>Drikke</v-btn></router-link> 
            
            <router-link to="/dessert"><v-btn>Dessert</v-btn></router-link>
        </div>
        <h1>Alle Desserter</h1>
        <DessertList />

    </div>
</template>

<script>
import DessertList from '@/components/Dessert/DessertList.vue'
export default {
    name:"Dessert",
    components: {
        DessertList
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
