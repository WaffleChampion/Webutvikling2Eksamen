<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
        <div id="nav">
            | <router-link to="/adddish">Legg til</router-link> |
            <router-link to="/deletedish">Fjern</router-link> |
            <router-link to="/editdish">Rediger</router-link> |
        </div>
        <h1>Legg til ny rett</h1>
        <DishForm />
    </div>
</template>

<script>
    import DishForm from '@/components/Dish/DishForm'
    export default {
        name: "AddDish",
        components: {
            DishForm
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
