<template>
    <div>
        | <router-link to="/adminhome">Home</router-link> |
       <div>
            <router-link to="/adddessert">Legg til</router-link> |
            <router-link to="/deletedessert">Fjern</router-link> |
            <router-link to="/editdessert">Rediger</router-link> |
        </div>
        <h1>Rediger Dessert</h1>

        <DessertEdit />
    </div>
</template>

<script>
import DessertEdit from '@/components/Dessert/DessertEdit.vue'
export default {
    name: "EditDessert",
    components: {
        DessertEdit
    }

}
</script>