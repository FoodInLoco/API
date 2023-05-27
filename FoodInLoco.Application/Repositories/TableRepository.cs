using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using ExpressionTable = FoodInLoco.Application.Data.Expressions.TableExpression;

namespace FoodInLoco.Application.Repositories
{
    public sealed class TableRepository : EFRepository<Table>, ITableRepository
    {
        public TableRepository(Context context) : base(context) { }

        public async Task<TableModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(ExpressionTable.Id(id)).Select(ExpressionTable.Model).SingleOrDefaultAsync();
        }

        public async Task<TableModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(ExpressionTable.Id(id))
                .Include(_ => _.Restaurant)
                .Select(ExpressionTable.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TableModelResponse>> GetTablesFromRestaurantAsync(Guid id)
        {
            return await Queryable.Where(ExpressionTable.RestaurantId(id))
                .Include(_ => _.Restaurant)
                .Select(ExpressionTable.Model).ToListAsync();
        }
        
        public async Task<IEnumerable<TableModelResponse>> ListModelAsync()
        {
            return await Queryable
                .Include(_ => _.Restaurant)
                .Select(ExpressionTable.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Table obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
