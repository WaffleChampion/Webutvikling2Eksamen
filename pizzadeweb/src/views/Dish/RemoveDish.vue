<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
        <div id="nav">
        | <router-link to="/adddish">Legg til</router-link> |
            <router-link to="/deletedish">Fjern</router-link> |
            <router-link to="/editdish">Rediger</router-link> |
        </div>
        <h1>Fjern rett</h1>
        <DishDelete />
    </div>
</template>

<script>
import DishDelete from '@/components/Dish/DishDelete.vue'
export default {
    name: "RemoveDish",
    components: {
        DishDelete
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