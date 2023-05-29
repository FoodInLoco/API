using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<RestaurantModelResponse?> GetModelByIdAsync(Guid id);
        
        Task<RestaurantModelResponse?> GetModelByIdWithRelationsAsync(Guid id);

        Task<Grid<RestaurantModelResponse>> GridAsync(GridParameters parameters);

        Task<IEnumerable<RestaurantModelResponse>> ListModelAsync();

        Task<RestaurantModelResponse?> GetModelByEmailAsync(string email);

        Task UpdateStatusAsync(Restaurant obj);

        Task<bool> AnyByEmailAsync(string email);

        Task<Restaurant?> GetByEmailAsync(string email);
    }
}
