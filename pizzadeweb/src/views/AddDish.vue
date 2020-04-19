<template>
    <div>
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
            <router-link to="/edit">Rediger</router-link>
        <div>
            <router-link to="/add">Legg til</router-link> |
            <router-link to="/delete">Fjern</router-link> |
            <router-link to="/edit">Rediger rett</router-link> |
        </div>
        <h1>Legg til ny rett</h1>
        <DishForm />
    </div>
</template>

<script>
import DishForm from '@/components/DishForm'
export default {
    name: "AddDish",
    components: {
        DishForm
    }
}
</script>

