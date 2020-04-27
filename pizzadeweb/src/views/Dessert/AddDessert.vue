<template>
    <div>
        | <router-link to="/adminhome">Home</router-link> |
       <div>
            <router-link to="/adddessert">Legg til</router-link> |
            <router-link to="/deletedessert">Fjern</router-link> |
            <router-link to="/editdessert">Rediger</router-link> |
        </div>
        <h1>Legg til ny Dessert</h1>
        <DessertForm />
    </div>
</template>

<script>
import DessertForm from '@/components/Dessert/DessertForm'
export default {
    name: "AddDessert",
    components: {
        DessertForm
    }
}
</script>

