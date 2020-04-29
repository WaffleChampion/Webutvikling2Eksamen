<template>
    <div class="background">
        <div>
            <router-link to="/">Home</router-link> |
            <router-link to="/meny">Menu</router-link> |
            <router-link to="/about">About</router-link> |
            <router-link to="/edit-main">Rediger</router-link>
        </div>
        <div> 
            <router-link to="/dishEdit">Redigere retter</router-link>
            <router-link to="/drinkEdit"> Redigere Drikke</router-link>
            <router-link to="/dedssertEdit">Redigere Dessert</router-link>
        </div>
    </div>
</template>

<style lang="scss">
.background{
  background: url('../components/images/Frontpage/pizzabackground.jpg');
  height: 100%;
  /*width: 100%;*/
  background-position: center;
  background-size: cover;


}
</style>