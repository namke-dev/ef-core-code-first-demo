using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services
{
    public interface ISuperHeroService
    {
        Task<IActionResult> GetAllSuperHero();
        Task<IActionResult> GetSuperHero(int id);
        Task<IActionResult> AddSuperHero(SuperHero superHero);
        Task<IActionResult> UpdateSuperHero(int id, SuperHero superHero);
        Task<IActionResult> DeleteSuperHero(int id);
    }
}