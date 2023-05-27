using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class OrderRepository : EFRepository<Order>, IOrderRepository
    {
        public OrderRepository(Context context) : base(context) { }

        public async Task<OrderModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(OrderExpression.Id(id)).Select(OrderExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<OrderModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(OrderExpression.Id(id))
                .Include(_ => _.Bill)
                .Include(_ => _.User)
                .Include(_ => _.Item)
                .Select(OrderExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<OrderModelResponse>> ListModelAsync()
        {
            return await Queryable
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
