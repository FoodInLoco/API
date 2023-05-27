using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface ITableRepository : IRepository<Table>
    {
        Task<TableModelResponse?> GetModelByIdAsync(Guid id);

        Task<TableModelResponse?> GetModelByIdWithRelationsAsync(Guid id);

        Task<IEnumerable<TableModelResponse>> GetTablesFromRestaurantAsync(Guid id);

        Task<IEnumerable<TableModelResponse>> ListModelAsync();

        Task UpdateStatusAsync(Table obj);
    }
}
