using FoodInLoco.Application.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly).Seed();
        }

        public DbSet<User> User { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
    }
}
