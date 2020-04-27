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
  path: '/adminhome',
  name: '/adminhome',
  component: ()=> import("../views/Admin.vue")
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
    path: '/edit-main',
    name: 'edit-main',
    component:() => import("../views/Edit.vue")
  },
  {
    path: '/editdish',
    name: 'editdish',
    component:()=> import("../views/Dish/EditDish.vue")
  },
  {
    path: '/adddish',
    name: 'adddish',
    component:()=> import("../views/Dish/AddDish.vue")
  },
  {
    path: '/deletedish',
    name: 'deletedish',
    component: ()=> import("../views/Dish/RemoveDish.vue")
  },
  {
    path: '/dishadmin',
    name: 'dishadmin',
    component: ()=> import("../views/DishAdmin.vue")
  },
  {
    path: '/drinkadmin',
    name: 'drinkadmin',
    component: ()=> import("../views/DrinkAdmin.vue")
  },
  {
    path: '/dessertadmin',
    name: 'dessertadmin',
    component: ()=> import("../views/DessertAdmin.vue")
  },
  {
  path: '/editdrink',
  name: 'editdrink',
  component:()=> import("../views/Drink/EditDrink.vue")
},
{
  path: '/adddrink',
  name: 'adddrink',
  component:()=> import("../views/Drink/AddDrink.vue")
},
{
  path: '/deletedrink',
  name: 'deletedrink',
  component: ()=> import("../views/Drink/RemoveDrink.vue")
},
{    
  path: '/editdessert',
name: 'editdessert',
component:()=> import("../views/Dessert/EditDessert.vue")
},
{
path: '/adddessert',
name: 'adddessert',
component:()=> import("../views/Dessert/AddDessert.vue")
},
{
path: '/deletedessert',
name: 'deletedessert',
component: ()=> import("../views/Dessert/RemoveDessert.vue")
}

]

const router = new VueRouter({
  routes
})

export default router
