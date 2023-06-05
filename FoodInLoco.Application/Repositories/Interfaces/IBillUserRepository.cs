using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IBillUserRepository : IRepository<BillUser>
    {
        Task<BillUserModelResponse?> GetFromKeys(Guid billId, Guid userId);
        
        Task UpdateStatusAsync(BillUser obj);
    }
}
