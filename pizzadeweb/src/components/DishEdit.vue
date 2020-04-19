<template>
    <div>
        <v-col cols="12" sm="6" lg="4" class="mx-auto">
            <DishList />
        </v-col>
    </div>
</template>
<script>
import DishList from "@/components/DishList.vue"
export default {
    name: "DishEdit",
    components: {
        DishList
    }
}
</script>