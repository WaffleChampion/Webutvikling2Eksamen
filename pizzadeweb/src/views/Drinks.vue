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
        <h1>Alle Drikker</h1>
        <DrinkList />

    </div>
</template>

<script>
import DrinkList from '@/components/DrinkList.vue'
export default {
    name:"Drinks",
    components: {
        DrinkList
    }
}
</script>