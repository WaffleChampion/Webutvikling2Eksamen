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

<<<<<<< HEAD
=======
<style lang="scss">
.background{
  background: url('../../components/images/Frontpage/pizzabackground.jpg');
  height: 100%;
  /*width: 100%;*/
  background-position: center;
  background-size: cover;
}

.background a{
    color: #ffffff;
  text-decoration: none;
  list-style-type: none;
  text-align: center;
}
/*
#nav a{ 
  color: #ffffff;
  text-decoration: none;
  list-style-type: none;
  text-align: center;
}*/
</style>
>>>>>>> parent of fcc33ce6... Revert "Merge branch 'Dev-branch' into design"
