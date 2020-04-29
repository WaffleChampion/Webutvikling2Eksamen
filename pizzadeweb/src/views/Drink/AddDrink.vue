<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
        <div id="nav">
            | <router-link to="/adddrink">Legg til</router-link> |
            <router-link to="/deletedrink">Fjern</router-link> |
            <router-link to="/editdrink">Rediger</router-link> |
        </div>
        <h1>Legg til ny Drikke</h1>
        <DrinkForm />
    </div>
</template>

<script>
import DrinkForm from '@/components/Drink/DrinkForm'
export default {
    name: "AddDrink",
    components: {
        DrinkForm
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

