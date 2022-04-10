using Microsoft.EntityFrameworkCore;
using SuperheroAPI.Models;

namespace SuperheroAPI.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
    }
    public DbSet<SuperHero> SuperHeros { get; set; }
  }
}