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
        private static List<SuperHero> superHeroes = new List<SuperHero> {
            new SuperHero
            {
                Id = 1,
                Name = "Spider Man",
                FirstName = "Peater",
                LastName = "Packer",
                Place = "New York city"
            },
            new SuperHero
            {
                Id = 2,
                Name = "Iron Man",
                FirstName = "Stark",
                LastName = "Tony",
                Place = "New York city"
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetAllSuperHero()
        {
            return Ok(superHeroes);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetSuperHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return NotFound("This hero doesnot exist");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> AddSuperHero(SuperHero superHero)
        {
            superHeroes.Add(superHero);
            return Ok(superHero);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateSuperHero(int id, SuperHero superHero)
        {
            var targetHero = superHeroes.Find(x => x.Id == id);
            if (targetHero is null)
            {
                return NotFound("This hero doesnot exist");
            }
            targetHero.FirstName = superHero.FirstName;
            targetHero.LastName = superHero.LastName;
            targetHero.Name = superHero.Name;
            targetHero.Place = superHero.Place;

            return Ok(targetHero);
        }
    }
}