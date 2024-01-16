using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> listSuperHeroes = new()
        {
            new() {
                Id = 1,
                Name = "Spider Man",
                FirstName = "Peater",
                LastName = "Packer",
                Place = "New York city"
            },
            new() {
                Id = 2,
                Name = "Iron Man",
                FirstName = "Stark",
                LastName = "Tony",
                Place = "New York city"
            }
        };
        public List<SuperHero>? AddSuperHero(SuperHero superHero)
        {
            listSuperHeroes.Add(superHero);
            return listSuperHeroes;
        }

        public List<SuperHero>? DeleteSuperHero(int id)
        {
            var hero = GetSuperHero(id);
            if (hero is null)
            {
                return null;
            }
            listSuperHeroes.Remove(hero);
            return listSuperHeroes;
        }

        public List<SuperHero>? GetAllSuperHero()
        {
            return listSuperHeroes;
        }

        public SuperHero? GetSuperHero(int id)
        {
            var superHero = listSuperHeroes.Find(x => x.Id == id);
            return superHero;
        }

        public List<SuperHero>? UpdateSuperHero(int id, SuperHero superHero)
        {
            var targetHero = GetSuperHero(id);
            if (targetHero is null)
            {
                return null;
            }
            targetHero.FirstName = superHero.FirstName;
            targetHero.LastName = superHero.LastName;
            targetHero.Name = superHero.Name;
            targetHero.Place = superHero.Place;

            return listSuperHeroes;
        }
    }
}