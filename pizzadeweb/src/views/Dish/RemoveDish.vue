<template>
    <div>
            | <router-link to="/adminhome">Home</router-link> |
                    <div>
            | <router-link to="/adddish">Legg til</router-link> |
            <router-link to="/deletedish">Fjern</router-link> |
            <router-link to="/editdish">Rediger</router-link> |
                    </div>
        <h1>Fjern rett</h1>
        <DishDelete />
    </div>
</template>

<script>
import DishDelete from '@/components/Dish/DishDelete.vue'
export default {
    name: "RemoveDish",
    components: {
        DishDelete
    }
}
</script>