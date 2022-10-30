using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public class EFRepository<T> : Repository<T> where T : class
    {
        public EFRepository(DbContext context) : base(new EFCommandRepository<T>(context), new EFQueryRepository<T>(context)) { }
    }
}
