<template>
    <div>
        | <router-link to="/adminhome">Home</router-link> |
        <div>
            <router-link to="/adddish">Legg til</router-link> |
            <router-link to="/deletedish">Fjern</router-link> |
            <router-link to="/editdish">Rediger rett</router-link> |
        </div>
    <DishList/>
    </div>
</template>

<script>
import DishList from '@/components/Dish/DishList.vue'
export default {
    name: "DishAdmin",
    components: {
        DishList
    }
}
</script>