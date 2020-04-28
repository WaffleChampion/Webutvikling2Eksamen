<template>
<v-app>
  <v-card-text>
  <v-card-title >
    <h1 class="display-1">Welcome to Pizza De Web</h1>
  </v-card-title>
  </v-card-text>
  <v-card-text>
    <v-btn>Meny</v-btn>
    
    
  </v-card-text>
  <v-contianer class="ImageCards">
    <v-layout row>
      <v-flex xs12 md6>
        <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>

      </v-flex>
     
      <v-flex xs12 md6>
        <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>


      </v-flex>
      <v-flex xs12 md6>
        <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>


      </v-flex>
      <v-flex xs12 md6>
        <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>
        


      </v-flex>
      <v-flex xs12 md6>
        <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>
        


      </v-flex>
      <v-flex xs12 md6>
        <v-card outline block class="cards"><v-img :src="require('./images/Frontpage/pizzaheader.jpg')"></v-img>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat ipsam ex modi, saepe distinctio amet, pariatur iste culpa quis, at quos dolorum earum similique quae aliquid cum quam nisi repudiandae?</v-card>
        


      </v-flex>
      
      
    </v-layout>
    
      
      
         
        
   
  </v-contianer>
</v-app>
  
    
</template>

<script>
 
  
</script>
<style lang="scss">
.ImageCards{
   margin: 10px 20px;
   
}
.display-1  {
  width: 50;
  margin: 0 auto;
  text-align: center;
  

}
.footer{
  display: flex;
  justify-content: center;
   padding-top:40%;
   background:blue

}
.cards{
  box-shadow: 0 4px 8px 0 rgba($color: #000000, $alpha: 1.0);
  flex: 0 0 50%; margin-right: 20px; margin-top: 20px; margin-left:100px;


}


</style>
