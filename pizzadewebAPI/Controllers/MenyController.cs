using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using pizzadewebAPI.Models;
using System.Linq;

namespace pizzadewebAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class MenyController : ControllerBase{

        private readonly MenyContext _context; 
        public MenyController(MenyContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Dishes>> Get(){
            List<Dishes> dishesList = await _context.Dishes.ToListAsync();
            return dishesList;
        }

        [HttpGet("{id}")]
        public async Task<Dishes> Get(int id){
            Dishes chosenDishes = await _context.Dishes.FirstOrDefaultAsync( dishes => dishes.id == id);
            return chosenDishes;
        }
                
        [HttpPost]
        public async Task<Dishes> Post(Dishes newDish){
            _context.Dishes.Add(newDish);
            await _context.SaveChangesAsync();
            return newDish;
        }

        [HttpPut]
        public async Task<Dishes> Put(Dishes changeDishes){
            _context.Update(changeDishes);
            await _context.SaveChangesAsync();
            return changeDishes;
        }

        [HttpDelete("{id}")]
        public async Task<Dishes> Delete(int id){
            Dishes deleteDishes = await _context.Dishes.FirstAsync( dishes => dishes.id == id );
            _context.Dishes.Remove(deleteDishes);
            await _context.SaveChangesAsync();
            return deleteDishes;
        }


    }


}