<template>
    <div class="background">
        | <router-link to="/adminhome">Home</router-link> |
        <div>
            | <router-link to="/adddrink">Legg til</router-link> |
            <router-link to="/deletedrink">Fjern</router-link> |
            <router-link to="/editdrink">Rediger</router-link> |
        </div>
        <h1>Rediger Drikke</h1>

        <DrinkEdit />
    </div>
</template>

<script>
import DrinkEdit from '@/components/Drink/DrinkEdit.vue'
export default {
    name: "EditDrink",
    components: {
        DrinkEdit
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
</style>