using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.data;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services
{
    public class SuperHeroService(DataContext context) : ISuperHeroService
    {
        private readonly DataContext _context = context;

        public async Task<List<SuperHero>?> AddSuperHero(SuperHero superHero)
        {
            _context.SuperHeroes.Add(superHero);
            await _context.SaveChangesAsync();
            return await _context.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHero>?> DeleteSuperHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero is null)
            {
                return null;
            }
            _context.SuperHeroes.Remove(hero);
            await _context.SaveChangesAsync();
            return await _context.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHero>?> GetAllSuperHero()
        {
            return await _context.SuperHeroes.ToListAsync();
        }

        public async Task<SuperHero?> GetSuperHero(int id)
        {
            var superHero = await _context.SuperHeroes.FindAsync(id);
            return superHero;
        }

        public async Task<List<SuperHero>?> UpdateSuperHero(int id, SuperHero superHero)
        {
            var targetHero = await GetSuperHero(id);
            if (targetHero is null)
            {
                return null;
            }
            targetHero.FirstName = superHero.FirstName;
            targetHero.LastName = superHero.LastName;
            targetHero.Name = superHero.Name;
            targetHero.Place = superHero.Place;

            await _context.SaveChangesAsync();
            return await GetAllSuperHero();
        }
    }
}