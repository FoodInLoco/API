using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data
{
    public sealed class UnitOfWork<T> : IUnitOfWork where T : DbContext
    {
        private readonly T _context;

        public UnitOfWork(T context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
