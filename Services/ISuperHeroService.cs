using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>?> GetAllSuperHero();
        Task<SuperHero?> GetSuperHero(int id);
        Task<List<SuperHero>?> AddSuperHero(SuperHero superHero);
        Task<List<SuperHero>?> UpdateSuperHero(int id, SuperHero superHero);
        Task<List<SuperHero>?> DeleteSuperHero(int id);
    }
}