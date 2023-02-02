using Microsoft.EntityFrameworkCore;
using TheShopper.Models;

namespace TheShopper.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
