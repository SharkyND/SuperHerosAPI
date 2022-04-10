using Microsoft.EntityFrameworkCore;
using SuperheroAPI.Data;
using SuperheroAPI.Interfaces;
using SuperheroAPI.Models;

namespace SuperheroAPI.Repositories
{
  public class SuperHeroRepository:ISuperHeroRepository
  {
    
    private readonly DataContext _dataContext;
    public SuperHeroRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<IEnumerable<SuperHero>> GetSuperHeroes()
    {
        var somelist = await _dataContext.SuperHeros.ToListAsync();
        foreach (var somelis in somelist)
        {
            Console.WriteLine(somelis.FirstName);
        } 
        return somelist;
    }
  }
}