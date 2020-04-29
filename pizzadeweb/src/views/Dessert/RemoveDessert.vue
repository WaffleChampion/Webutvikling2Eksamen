<template>
    <div>
        | <router-link to="/adminhome">Home</router-link> |
       <div>
            <router-link to="/adddessert">Legg til</router-link> |
            <router-link to="/deletedessert">Fjern</router-link> |
            <router-link to="/editdessert">Rediger</router-link> |
        </div>

        <h1>Fjern rett</h1>
        <DessertDelete />
    </div>
</template>

<script>
import DessertDelete from '@/components/Dessert/DessertDelete.vue'
export default {
    name: "RemoveDessert",
    components: {
        DessertDelete
    }
}
</script>