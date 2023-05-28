using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IBillUserRepository : IRepository<BillUser>
    {
        Task UpdateStatusAsync(BillUser obj);
    }
}
