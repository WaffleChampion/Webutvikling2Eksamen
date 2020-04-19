<template>
    <div>
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
            <router-link to="/edit">Rediger</router-link>

        <div>
            <router-link to="/add">Legg til</router-link> |
            <router-link to="/delete">Fjern</router-link> |
            <router-link to="/edit">Rediger rett</router-link> |
        </div>
        <h1>Fjern rett</h1>
        <DishDelete />
    </div>
</template>

<script>
import DishDelete from '@/components/DishDelete.vue'
export default {
    name: "RemoveDish",
    components: {
        DishDelete
    }
}
</script>