using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RecipeWebsite.Models.Domain;

namespace RecipeWebsite.Data
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions options) : base(options)
        {
        }
            public DbSet<Recipe> Recipe { set; get; }
        
    }
}
