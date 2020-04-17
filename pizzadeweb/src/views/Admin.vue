<template>
    <div>
        <div id="nav">
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
            <router-link to="/edit">Rediger</router-link>

        </div>
        <HelloWorld msg="Welcome to Your Vue.js App"/>

    </div>
</template>

<script>
import HelloWorld from '@/components/HelloWorld.vue'
export default {
    name: "CustumerHome",
    components:{
        HelloWorld
    }
    
}
</script>