using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FoodInLoco.Application.Data
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "Host=ec2-44-207-253-50.compute-1.amazonaws.com;Database=d5l5apig829nrt;Username=lkagcwvzznyyeh;Password=9858fa2603ac764902f174a7df75e241169f9c5f18fa2c3460f1ee29d3a8cf60";

            return new Context(new DbContextOptionsBuilder<Context>().UseNpgsql(connectionString).Options);
        }
    }
}
