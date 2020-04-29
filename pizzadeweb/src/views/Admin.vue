<template>
    <div class="background">
        <h1>Velg</h1>
        <div id="nav">
            | <router-link to="/dishadmin" class="link">Retter</router-link> |
            <router-link to="/drinkadmin" class="link">Drikke</router-link> |
            <router-link to="/dessertadmin" class="link">Dessert</router-link> |

        </div>

    </div>
</template>

<script>
export default {
    name: "Admin",
    components:{
        
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