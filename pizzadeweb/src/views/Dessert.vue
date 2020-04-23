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
        <h1>Alle Desserter</h1>
        <DessertList />

    </div>
</template>

<script>
import DessertList from '@/components/Dessert/DessertList.vue'
export default {
    name:"Dessert",
    components: {
        DessertList
    }
}
</script>