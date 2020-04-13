<template>
    <div>
        <h1>Alle Retter</h1>
        <DishList />
        <DrinkList />
    </div>
</template>

<script>
import DishList from '@/components/DishList.vue'
import DrinkList from '@/components/DrinkList.vue'
export default {
name: 'Meny',
  components: {
    DishList,
    DrinkList
  }
}
</script>