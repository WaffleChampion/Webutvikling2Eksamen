<template>
    <div id="background">
        <h1>Velg</h1>
        <div id="nav">
            <router-link to="/dishadmin">Retter</router-link> |
            <router-link to="/drinkadmin">Drikke</router-link> |
            <router-link to="/dessertadmin">Dessert</router-link>

        </div>

    </div>
</template>

<script>
export default {
    name: "AdminHome",
    components:{
        
    }
    
}
</script>

<style lang="scss">
#background{
  background: url('../components/images/Frontpage/pizzabackground.jpg');
  height: 100%;
  /*width: 100%;*/
  background-position: center;
  background-size: cover;
}
</style>