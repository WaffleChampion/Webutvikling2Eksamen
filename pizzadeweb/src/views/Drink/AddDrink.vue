<template>
    <div>
        | <router-link to="/adminhome">Home</router-link> |
        <div>
            | <router-link to="/adddrink">Legg til</router-link> |
            <router-link to="/deletedrink">Fjern</router-link> |
            <router-link to="/editdrink">Rediger</router-link> |
        </div>
        <h1>Legg til ny Drikke</h1>
        <DrinkForm />
    </div>
</template>

<script>
import DrinkForm from '@/components/Drink/DrinkForm'
export default {
    name: "AddDrink",
    components: {
        DrinkForm
    }
}
</script>

