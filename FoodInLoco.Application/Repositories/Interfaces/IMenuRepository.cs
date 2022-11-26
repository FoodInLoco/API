using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IMenuRepository : IRepository<Menu>
    {
        Task<MenuModelResponse> GetModelByIdAsync(Guid id);

        Task<MenuModelResponse> GetModelByIdWithRelationsAsync(Guid id);

        Task<IEnumerable<MenuModelResponse>> ListModelAsync();
        
        Task<IEnumerable<MenuModelResponse>> ListModelByRestaurantAsync(Guid restaurantId);

        Task UpdateStatusAsync(Menu obj);
    }
}
