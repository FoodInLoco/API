using FoodInLoco.Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;

namespace FoodInLoco.Application.Extensions
{
    public static class EFExtensions
    {
        public static void AddContext<T>(this IServiceCollection services, Action<DbContextOptionsBuilder> options) where T : DbContext
        {
            services.AddDbContextPool<T>(options);
            services.BuildServiceProvider().GetRequiredService<T>().Database.Migrate();
            services.AddScoped<IUnitOfWork, UnitOfWork<T>>();
        }

        public static DbSet<T> CommandSet<T>(this DbContext context) where T : class
        {
            return context.DetectChangesLazyLoading(enabled: true).Set<T>();
        }

        public static DbContext DetectChangesLazyLoading(this DbContext context, bool enabled)
        {
            context.ChangeTracker.AutoDetectChangesEnabled = enabled;
            context.ChangeTracker.LazyLoadingEnabled = enabled;
            context.ChangeTracker.QueryTrackingBehavior = ((!enabled) ? QueryTrackingBehavior.NoTracking : QueryTrackingBehavior.TrackAll);
            return context;
        }

        public static IQueryable<T> QuerySet<T>(this DbContext context) where T : class
        {
            return context.DetectChangesLazyLoading(enabled: false).Set<T>().AsNoTracking();
        }

        public static object[] PrimaryKeyValues<T>(this DbContext context, object entity)
        {
            return context.Model.FindEntityType(typeof(T))?.FindPrimaryKey()?.Properties.Select((IProperty property) => entity.GetType().GetProperty(property.Name)?.GetValue(entity, null)).ToArray();
        }
    }
}
