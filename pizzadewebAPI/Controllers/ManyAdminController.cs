using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using pizzadewebAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace pizzadewebAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class MenyAdminController : ControllerBase{

        private readonly MenyContext _context; 
        private readonly IWebHostEnvironment _hosting;
        public MenyAdminController(MenyContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
        }

        [HttpGet]
        public async Task<IEnumerable<Dishes>> Get(){
            List<Dishes> dishesList = await _context.Dishes.ToListAsync();
            return dishesList;
        }

        [HttpPost]
        [Route("[action]")]
        public void UploadImage(IFormFile file){
            string webRootPath = _hosting.WebRootPath;
            string absolutePath = Path.Combine($"{webRootPath}/images/Dishes/{file.FileName}");
            using(var fileStream = new FileStream( absolutePath, FileMode.Create )){
                file.CopyTo( fileStream );
            }
        }


    }


}