using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllSuperHero()
        {
            var superHero = new SuperHero
            {
                Id = 1,
                Name = "Spider Man",
                FirstName = "Peater",
                LastName = "Packer",
                Place = "New York city"
            };

            return Ok(superHero);
        }
    }
}