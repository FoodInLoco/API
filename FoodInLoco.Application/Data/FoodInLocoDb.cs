using FoodInLoco.Application.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data;

public class FoodInLocoDb : DbContext
{
    public FoodInLocoDb(DbContextOptions<FoodInLocoDb> options) : base(options)
    {

    }

    public DbSet<User> User { get; set; }
    public DbSet<Restaurant> Restaurant { get; set; }
}