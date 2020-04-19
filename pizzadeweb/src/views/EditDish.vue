<template>
    <div>
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
            <router-link to="/edit">Rediger</router-link>
        <h1>Rediger rett</h1>
        <DishEdit />
    </div>
</template>

<script>
import DishEdit from '@/components/DishEdit.vue'
export default {
    name: "RemoveDish",
    components: {
        DishEdit
    }
}
</script>