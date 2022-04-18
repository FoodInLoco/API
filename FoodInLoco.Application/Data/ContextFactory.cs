using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FoodInLoco.Application.Data
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "Host=ec2-34-207-12-160.compute-1.amazonaws.com;Database=d341nsi2add60v;Username=dqfsvxtbmltnef;Password=2458f4cff34fa349a406a4dae4501e5020f24d293f079097c311d833de2e0e45";

            return new Context(new DbContextOptionsBuilder<Context>().UseNpgsql(connectionString).Options);
        }
    }
}
