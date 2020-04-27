<template>
    <div>
            | <router-link to="/adminhome">Home</router-link> |
                    <div>
            | <router-link to="/adddish">Legg til</router-link> |
            <router-link to="/deletedish">Fjern</router-link> |
            <router-link to="/editdish">Rediger</router-link> |
        </div>
        <h1>Legg til ny rett</h1>
        <DishForm />
    </div>
</template>

<script>
import DishForm from '@/components/Dish/DishForm'
export default {
    name: "AddDish",
    components: {
        DishForm
    }
}
</script>

