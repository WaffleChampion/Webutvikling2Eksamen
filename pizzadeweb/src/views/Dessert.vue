<template>
    <div class="background">
        <div id="nav">
            <router-link to="/dishes">Retter</router-link> |
            <router-link to="/drinks">Drikke</router-link> |
            <router-link to="/dessert">Dessert</router-link>|
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
.background a{
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