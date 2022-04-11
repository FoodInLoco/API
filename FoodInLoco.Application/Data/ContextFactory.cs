using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FoodInLoco.Application.Data
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "Host=ec2-44-194-167-63.compute-1.amazonaws.com;Database=d7dlmhf0lrpaf0;Username=yrgdqldukuminv;Password=2c3c9a7bf2e17311a0618d11a1cd530d1f36af12a5959ad601828f38c14a7f01";

            return new Context(new DbContextOptionsBuilder<Context>().UseNpgsql(connectionString).Options);
        }
    }
}
