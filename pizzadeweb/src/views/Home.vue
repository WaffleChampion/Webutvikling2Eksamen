<template>
    <Frontpage/>
</template>

<script>
// @ is an alias to /src
import Frontpage from '@/components/Frontpage.vue'

export default {
  name: 'Home',
  components: {
    Frontpage
  }
}
</script>
<style lang="scss" >
.header{
  position: absolute;
  color: rgb(197, 35, 35);
  height: 30px;
  width: 100%;
}
</style>
