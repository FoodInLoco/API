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
    public sealed class OrderRepository : EFRepository<Order>, IOrderRepository
    {
        private readonly Context _dbContext;

        public OrderRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<OrderModelResponse?> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(OrderExpression.Id(id)).Select(OrderExpression.Model).SingleOrDefaultAsync();
        }

        public Task<OrderModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return Queryable.Where(OrderExpression.Id(id))
                //TODO: fazer ligação com entidade da conta
                .Include(_ => _.Bill)
                .Include(_ => _.User)
                .Include(_ => _.Item)
                .Select(OrderExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<OrderModelResponse>> ListModelAsync()
        {
            return await Queryable
                //TODO: fazer ligação com entidade da conta
                .Include(_ => _.Bill)
                .Include(_ => _.User)
                .Include(_ => _.Item)
                .Select(OrderExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Order obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
