using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperheroAPI.Data;
using SuperheroAPI.Interfaces;
using SuperheroAPI.Models;

namespace SuperheroAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperHeroController:ControllerBase
    {   
        private readonly ISuperHeroRepository _superHeroRepository;
        private readonly DataContext _dataContext;
        public SuperHeroController(ISuperHeroRepository superHeroRepository)
        {
            _superHeroRepository = superHeroRepository;
        }
        
        private IEnumerable<SuperHero> _heros = new List<SuperHero>
            {
                new SuperHero {
                    Id = 1,
                    Name = "SpiderMan",
                    FirstName="Pe",
                    LastName="Par",
                    Place="New York"
                }
            };
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuperHero>>> Get()
        { 
            var superHeros = await _superHeroRepository.GetSuperHeroes();
            if (!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            return Ok(superHeros);
        }
/*        [HttpPost]
         public async Task<ActionResult<IEnumerable<SuperHero>>> AddHero(SuperHero superHero)
        {   _dataContext.SuperHeros.Add(superHero);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.SuperHeros.ToListAsync());
        }
*/
    }
}