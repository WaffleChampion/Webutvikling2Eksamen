<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
       <div id="nav"> 
            <router-link to="/adddessert">Legg til</router-link> |
            <router-link to="/deletedessert">Fjern</router-link> |
            <router-link to="/editdessert">Rediger</router-link> |
        </div>
        <h1>Rediger Dessert</h1>

        <DessertEdit />
    </div>
</template>

<script>
import DessertEdit from '@/components/Dessert/DessertEdit.vue'
export default {
    name: "EditDessert",
    components: {
        DessertEdit
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