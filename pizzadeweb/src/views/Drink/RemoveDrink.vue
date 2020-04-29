<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
        <div id="nav">
            | <router-link to="/adddrink">Legg til</router-link> |
            <router-link to="/deletedrink">Fjern</router-link> |
            <router-link to="/editdrink">Rediger</router-link> |
        </div>

        <h1>Fjern rett</h1>
        <DrinkDelete />
    </div>
</template>

<script>
import DrinkDelete from '@/components/Drink/DrinkDelete.vue'
export default {
    name: "RemoveDrink",
    components: {
        DrinkDelete
    }
}
</script>

<style lang="scss">
.background{
  background: url('../../components/images/Frontpage/pizzabackground.jpg');
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