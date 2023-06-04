using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<OrderModelResponse?> GetModelByIdAsync(Guid id);

        Task<OrderModelResponse?> GetModelByIdWithRelationsAsync(Guid id);

        Task<IEnumerable<OrderModelResponse>> ListByBillIdModelAsync(Guid id);
        
        Task<IEnumerable<OrderModelResponse>> ListModelAsync();

        Task UpdateStatusAsync(Order obj);
    }
}
