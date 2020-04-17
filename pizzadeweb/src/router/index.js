import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

  const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '/meny',
    name: 'Meny',
    component: () => import("../views/Meny.vue")
  },
  {
    path: '/costumer',
    name: 'costumer',
    component: () => import("../views/Costumer.vue")
  },
  {
    path: '/admin',
    name: 'admin',
    component: () => import("../views/Admin.vue")
  },
  {
    path: '/dishes',
    name: 'dishes',
    component: () => import("../views/Dishes.vue")
  },
  {
    path: '/drinks',
    name: 'drinks',
    component: () => import("../views/Drinks.vue")
  },
  {
    path: '/dessert',
    name: 'dessert',
    component: () => import("../views/Dessert.vue")
  },
  {
    path: '/edit',
    name: 'edit',
    component:() => import("../views/AddDish.vue")
  }
  //{    
   // path: '/add-dish',
   // name: 'Add-Dish',
   // component: () => import("../views/AddDish.vue")
 // },
  //{
    //path: '/remove-dish',
  //  name: 'Remove-Dish',
    //component: () => import("../views/RemoveDish")
  //}
]

const router = new VueRouter({
  routes
})

export default router
