using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly).Seed();
        }
    }
}
