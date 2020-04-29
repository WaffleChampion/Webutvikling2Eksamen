<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
        <div id="nav">
            <router-link to="/adddrink">Legg til</router-link> |
            <router-link to="/deletedrink">Fjern</router-link> |
            <router-link to="/editdrink">Rediger</router-link> |
        </div>
        <DrinkList/>
    </div>
</template>

<script>
import DrinkList from '@/components/Drink/DrinkList'
export default {
    name: "DrinkAdmin",
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
}
</style>