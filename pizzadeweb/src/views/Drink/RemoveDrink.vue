<template>
    <div>
        | <router-link to="/adminhome">Home</router-link> |
        <div>
            | <router-link to="/adddrink">Legg til</router-link> |
            <router-link to="/deletedrink">Fjern</router-link> |
            <router-link to="/editdrink">Rediger</router-link> |
        </div>

        <h1>Fjern rett</h1>
        <DrinkDelete />
    </div>
</template>

<script>
import DrinkDelete from '@/components/Drink/DrinkDelete.vue'
export default {
    name: "RemoveDrink",
    components: {
        DrinkDelete
    }
}
</script>