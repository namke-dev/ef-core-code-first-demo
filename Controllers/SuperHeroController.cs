using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services;

namespace SuperHeroAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupperHeroController(ISuperHeroService superHeroService) : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService = superHeroService;

        [HttpGet]
        public async Task<IActionResult> GetAllSuperHero()
        {
            var result = _superHeroService.GetAllSuperHero();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetSuperHero(int id)
        {
            var result = _superHeroService.GetSuperHero(id);
            if (result is null)
                return NotFound("This hero doesnot exist");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddSuperHero(SuperHero superHero)
        {
            var result = _superHeroService.AddSuperHero(superHero);
            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateSuperHero(int id, SuperHero superHero)
        {
            var result = _superHeroService.UpdateSuperHero(id, superHero);
            if (result is null)
            {
                return NotFound("This hero doesnot exist");
            }
            return Ok(result);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteSuperHero(int id)
        {
            var result = _superHeroService.DeleteSuperHero(id);
            if (result is null)
                return NotFound("This hero doesnot exist");
            return Ok(result);
        }
    }
}