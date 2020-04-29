<template>
  <span >
    <div class="background">
      
      <v-card-text>
        <v-card-title >
          <h1 class="display-1">Welcome to Pizza De Web</h1>
        </v-card-title>
      </v-card-text>

      <v-card-text>
        <router-link to="/meny"><v-btn><a>Meny</a></v-btn></router-link>

        <div id="carousel1">
          <v-carousel image="auto" hide-delimiters>
          <v-carousel-item
            v-for="(item,i) in items"
            :key="i"
            :src="item.src"
            reverse-transition="fade-transition"
            transition="fade-transition"
            ></v-carousel-item>
          </v-carousel>
        </div>
      </v-card-text>

      <v-contianer class="ImageCards">
        <v-row justify="space-around">

          <v-col cols="12" md="6">
            <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.png')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>

          </v-col>
          <v-col cols="12" md="6">
            <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.png')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>

          </v-col>
          <v-col cols="12" md="6">
            <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader2.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>
          </v-col>

          <v-col cols="12" md="6">
            <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader2.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>
          </v-col>  

        </v-row> 
      </v-contianer> 
    </div>
  </span>   
</template>


 
  
<script>
  export default {
    data () {
      return {
        items: [
          {
            src: require("../assets/images/chorizo.jpg"),
            title: 'hei',
          },
          {
            src: require("../assets/images/pastacarbonara.jpg")
          },
          {
            src: require("../assets/images/pizzamargerita.jpg")
          },
          {
            src: require("../assets/images/Hawaii.jpg")
          },
        ],
      }
    },
  }
</script>

<style lang="scss">

#carousel1{
  background-size: cover;
  padding:20%;
  padding-top: 5%;
  padding-bottom: 10%;
  overflow: hidden;
  max-width: 100%;
}

#carousel1{
  color:none;
}

@media all and (min-width: 0.1px) and (max-width: 599.9px){#carousel1{display:none;}}

.background{
  background: url('images/Frontpage/pizzabackground.jpg');
  height: 100%;
  /*width: 100%;*/
  background-position: center;
  background-size: cover;
}

.ImageCards{
   margin: 10px 20px; 
}

.display-1  {
  width: 50;
  margin: 0 auto;
  text-align: center;
}

.cards{
  box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
  flex: 0 0 50%; margin-right: 100px; margin-top: 20px; margin-left:100px;
}
</style>
