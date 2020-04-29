<template>
    <div>
        <div>
            <router-link to="/adddrink">Legg til</router-link> |
            <router-link to="/deletedrink">Fjern</router-link> |
            <router-link to="/editdrink">Rediger</router-link> |
        </div>
        <DrinkList/>
    </div>
</template>

<script>
import DrinkList from '@/components/Drink/DrinkList'
export default {
    name: "DrinkAdmin",
    components: {
        DrinkList
    }
}
</script>