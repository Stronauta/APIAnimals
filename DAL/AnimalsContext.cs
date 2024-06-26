using Microsoft.EntityFrameworkCore;
using WebApiAnimals.Models;

namespace WebApiAnimals.DAL
{
    public class AnimalsContext: DbContext
    {
        public AnimalsContext(DbContextOptions<AnimalsContext> options) : base (options)
        {
            
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
