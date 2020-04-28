<template>
    <div>
              <div>
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
      </div>
        <div>
            <router-link to="/dishes">Retter</router-link> |
            <router-link to="/drinks">Drikke</router-link> |
            <router-link to="/dessert">Dessert</router-link>|
        </div>
        <h1>Alle Retter</h1>
        <DishList />

    </div>
</template>

<script>
import DishList from '@/components/Dish/DishList.vue'
export default {
    name:"Dishes",
    components: {
        DishList
    }
}
</script>