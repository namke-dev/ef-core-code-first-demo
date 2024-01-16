using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services
{
    public interface ISuperHeroService
    {
        List<SuperHero>? GetAllSuperHero();
        SuperHero? GetSuperHero(int id);
        List<SuperHero>? AddSuperHero(SuperHero superHero);
        List<SuperHero>? UpdateSuperHero(int id, SuperHero superHero);
        List<SuperHero>? DeleteSuperHero(int id);
    }
}