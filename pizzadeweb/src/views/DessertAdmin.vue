<template>
    <div class="background">
        
        <div id="nav">
        | <router-link to="/adminhome">Home</router-link> |
        </div>

        <div id="nav">
            <router-link to="/adddessert">Legg til</router-link> |
            <router-link to="/deletedessert">Fjern</router-link> |
            <router-link to="/editdessert">Rediger rett</router-link> |
        </div>

        <DessertList/>

    </div>
</template>

<script>
import DessertList from '@/components/Dessert/DessertList.vue'
export default {
    name: "DessertAdmin",
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
}

</style>