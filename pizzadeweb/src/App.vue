<template>
<v-app>
  
  <div id="app">
    
    <div id="nav">
      <div id="titlename">
        <h1><span class="colorOftitle">PIZZA</span>de Web</h1>
      </div>
      
      <router-link to="/costumer"><nav><ul><li><a>Customer</a></li></ul></nav></router-link>
      <router-link to="/admin"><nav><ul><li><a>Admin</a></li></ul></nav></router-link>
      <router-link to="/meny"><nav><ul><li><a>Meny</a></li></ul></nav></router-link>
      <router-link to="/about"><nav><ul><li><a>About</a></li></ul></nav></router-link>
      
    </div>
    <router-view/>
    <router-link to="/meny"><h1></h1></router-link> 
            <router-link to="/about"></router-link> 
  </div>
  
<v-footer class="footer"><h1>Footer</h1></v-footer>
</v-app>
</template>

<style lang="scss">
.footer{
  
  background-color: #42b983;
  color: #000;

}

#titlename span{
  
  color: rgb(235, 231, 20);
  padding: 30px;
  

}


#nav{
  height: 100px;
  background-color: #3e413f;
  overflow: hidden;
  margin: auto;
  color: #ffff;
  padding: 40px;
  
  
  

}
#nav a{
  color:#ffff;
  text-decoration: none;
  text-transform: uppercase;
  font-size: 20px;
  float: right;
  margin-top: 5px;
  
}
#nav ul{
  margin: 0;
  padding: 0;
}
#nav li{
 
  display: grid;
  padding: 0 10px 0 10px;

}


#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  
}

#nav {
  
  padding-top:5px;
  min-height: 70px;
  border-bottom: rgb(235, 231, 20) 3px solid;

  a {
    font-weight: bold;
    

    &.router-link-exact-active {
      color: #42b983;
    }
  }

}
</style>
