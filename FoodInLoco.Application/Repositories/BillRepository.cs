using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq;

namespace FoodInLoco.Application.Repositories
{
    public sealed class BillRepository : EFRepository<Bill>, IBillRepository
    {
        private readonly Context _dbContext;

        public BillRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<BillModelResponse?> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(BillExpression.Id(id)).Select(BillExpression.Model).SingleOrDefaultAsync();
        }

        public Task<BillModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return Queryable.Where(BillExpression.Id(id))
                //TODO: fazer ligação com entidade da conta
                .Include(_ => _.Table)
                .Select(BillExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<BillModelResponse>> ListModelAsync()
        {
            return await Queryable
                //TODO: fazer ligação com entidade da conta
                .Include(_ => _.Table)
                .Select(BillExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Bill obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
