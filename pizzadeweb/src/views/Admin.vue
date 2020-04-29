<template>
<<<<<<< HEAD
    <div id="background">
=======
    <div class="background">
>>>>>>> parent of fcc33ce6... Revert "Merge branch 'Dev-branch' into design"
        <h1>Velg</h1>
        <div id="nav">
            | <router-link to="/dishadmin" class="link">Retter</router-link> |
            <router-link to="/drinkadmin" class="link">Drikke</router-link> |
            <router-link to="/dessertadmin" class="link">Dessert</router-link> |

        </div>
        <DishList/>
    </div>
</template>

<script>
import DishList from "@/components/Dish/DishList.vue"
export default {
<<<<<<< HEAD
    name: "AdminHome",
=======
    name: "Admin",
>>>>>>> parent of fcc33ce6... Revert "Merge branch 'Dev-branch' into design"
    components:{
        DishList
    }
    
}
</script>

<style lang="scss">
<<<<<<< HEAD
#background{
=======
.background{
>>>>>>> parent of fcc33ce6... Revert "Merge branch 'Dev-branch' into design"
  background: url('../components/images/Frontpage/pizzabackground.jpg');
  height: 100%;
  /*width: 100%;*/
  background-position: center;
  background-size: cover;
}
<<<<<<< HEAD
=======

#nav a{
    
  color: #ffffff;
  text-decoration: none;
  list-style-type: none;
  text-align: center;
}
>>>>>>> parent of fcc33ce6... Revert "Merge branch 'Dev-branch' into design"
</style>