using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using pizzadewebAPI.Models;
using System.Linq;

namespace pizzadewebAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class DrinkController : ControllerBase{

        private readonly MenyContext _context; 
        public DrinkController(MenyContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Drinks>> Get(){
            List<Drinks> drinksList = await _context.Drinks.ToListAsync();
            return drinksList;
        }

        [HttpGet("{id}")]
        public async Task<Drinks> Get(int id){
            Drinks chosenDrinks = await _context.Drinks.FirstOrDefaultAsync( drinks => drinks.id == id);
            return chosenDrinks;
        }
                
        [HttpPost]
        public async Task<Drinks> Post(Drinks newDrink){
            _context.Drinks.Add(newDrink);
            await _context.SaveChangesAsync();
            return newDrink;
        }

        [HttpPut]
        public async Task<Drinks> Put(Drinks changeDrinks){
            _context.Update(changeDrinks);
            await _context.SaveChangesAsync();
            return changeDrinks;
        }

        [HttpDelete("{id}")]
        public async Task<Drinks> Delete(int id){
            Drinks deleteDrinks = await _context.Drinks.FirstAsync( drinks => drinks.id == id );
            _context.Drinks.Remove(deleteDrinks);
            await _context.SaveChangesAsync();

            return deleteDrinks;
        }


    }


}