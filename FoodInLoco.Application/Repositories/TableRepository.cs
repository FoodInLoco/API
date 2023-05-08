using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq;
using ExpressionTable = FoodInLoco.Application.Data.Expressions.TableExpression;

namespace FoodInLoco.Application.Repositories
{
    public sealed class TableRepository : EFRepository<Table>, ITableRepository
    {
        private readonly Context _dbContext;

        public TableRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<TableModelResponse?> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(ExpressionTable.Id(id)).Select(ExpressionTable.Model).SingleOrDefaultAsync();
        }

        public Task<TableModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return Queryable.Where(ExpressionTable.Id(id))
                //TODO: fazer ligação com entidade da conta
                .Include(_ => _.Restaurant)
                .Select(ExpressionTable.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<TableModelResponse>> ListModelAsync()
        {
            return await Queryable
                //TODO: fazer ligação com entidade da conta
                .Include(_ => _.Restaurant)
                .Select(ExpressionTable.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Table obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
