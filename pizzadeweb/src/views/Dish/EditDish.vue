<template>
    <div>
            | <router-link to="/adminhome">Home</router-link> |
                    <div>
            | <router-link to="/adddish">Legg til</router-link> |
            <router-link to="/deletedish">Fjern</router-link> |
            <router-link to="/editdish">Rediger</router-link> |
                    </div>
        <h1>Rediger rett</h1>

        <DishEdit />
    </div>
</template>

<script>
import DishEdit from '@/components/Dish/DishEdit.vue'
export default {
    name: "EditDish",
    components: {
        DishEdit
    }

}
</script>