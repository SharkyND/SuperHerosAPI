using SuperheroAPI.Models;

namespace SuperheroAPI.Interfaces
{
    public interface ISuperHeroRepository
    {
        Task<IEnumerable<SuperHero>> GetSuperHeroes();
    }
}