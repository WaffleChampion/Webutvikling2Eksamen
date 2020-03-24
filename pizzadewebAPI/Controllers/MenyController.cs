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


    }


}