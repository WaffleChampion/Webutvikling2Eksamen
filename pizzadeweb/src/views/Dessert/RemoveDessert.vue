<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
       <div id="nav">
            <router-link to="/adddessert">Legg til</router-link> |
            <router-link to="/deletedessert">Fjern</router-link> |
            <router-link to="/editdessert">Rediger</router-link> |
        </div>

        <h1>Fjern rett</h1>
        <DessertDelete />
    </div>
</template>

<script>
import DessertDelete from '@/components/Dessert/DessertDelete.vue'
export default {
    name: "RemoveDessert",
    components: {
        DessertDelete
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

.background a{
    color: #ffffff;
  text-decoration: none;
  list-style-type: none;
  text-align: center;
}
</style>