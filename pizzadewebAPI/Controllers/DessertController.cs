using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using pizzadewebAPI.Models;
using System.Linq;

namespace pizzadewebAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class DessertsController : ControllerBase{

        private readonly MenyContext _context; 
        public DessertsController(MenyContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Desserts>> Get(){
            List<Desserts> dessertsList = await _context.Desserts.ToListAsync();
            return dessertsList;
        }

        [HttpGet("{id}")]
        public async Task<Desserts> Get(int id){
            Desserts chosenDesserts = await _context.Desserts.FirstOrDefaultAsync( desserts => desserts.id == id);
            return chosenDesserts;
        }
                
        [HttpPost]
        public async Task<Desserts> Post(Desserts newDessert){
            _context.Desserts.Add(newDessert);
            await _context.SaveChangesAsync();
            return newDessert;
        }

        [HttpPut]
        public async Task<Desserts> Put(Desserts changeDesserts){
            _context.Update(changeDesserts);
            await _context.SaveChangesAsync();
            return changeDesserts;
        }

        [HttpDelete("{id}")]
        public async Task<Desserts> Delete(int id){
            Desserts deleteDesserts = await _context.Desserts.FirstAsync( desserts => desserts.id == id );
            _context.Desserts.Remove(deleteDesserts);
            await _context.SaveChangesAsync();

            return deleteDesserts;
        }


    }


}