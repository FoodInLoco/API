using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IBillRepository : IRepository<Bill>
    {
        Task<BillModelResponse?> GetModelByIdAsync(Guid id);

        Task<BillModelResponse?> GetModelByIdWithRelationsAsync(Guid id);

        Task<BillModelResponse?> GetActiveBillByTableAsync(Guid id);

        Task<IEnumerable<BillModelResponse>> GetActiveBillsByUserAsync(Guid id);

        Task<IEnumerable<BillModelResponse>> ListModelAsync();

        Task UpdateStatusAsync(Bill obj);
    }
}
