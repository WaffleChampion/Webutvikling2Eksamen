<template>
    <div>

        <div>
            <router-link to="/adddessert">Legg til</router-link> |
            <router-link to="/deletedessert">Fjern</router-link> |
            <router-link to="/editdessert">Rediger rett</router-link> |
        </div>
        <DessertList/>
    </div>
</template>

<script>
import DessertList from '@/components/Dessert/DessertList.vue'
export default {
    name: "DessertAdmin",
    components: {
        DessertList
    }
}
</script>