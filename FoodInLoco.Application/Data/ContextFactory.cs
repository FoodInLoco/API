using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FoodInLoco.Application.Data
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "Host=ec2-52-70-45-163.compute-1.amazonaws.com;Database=dehd7sqq8cqgmn;Username=tetnyugdhyakpy;Password=a7d40faaa9c9f010ffb57aae4813b3725db2bf567d5c0c4f87f3a7a8b3fdfcfa";

            return new Context(new DbContextOptionsBuilder<Context>().UseNpgsql(connectionString).Options);
        }
    }
}
