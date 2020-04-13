<template>
    <div>
        <h1>Alle Retter</h1>
        <DishList />
    </div>
</template>

<script>
import DishList from '@/components/DishList.vue'
export default {
name: 'Meny',
  components: {
    DishList
  }
}
</script>