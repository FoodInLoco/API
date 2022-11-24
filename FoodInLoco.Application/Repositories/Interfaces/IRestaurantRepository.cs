using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<RestaurantModelResponse> GetModelByIdAsync(Guid id);
        
        Task<RestaurantModelResponse> GetModelByIdWithRelationsAsync(Guid id);

        Task<Grid<RestaurantModelResponse>> GridAsync(GridParameters parameters);

        Task<IEnumerable<RestaurantModelResponse>> ListModelAsync();

        Task UpdateStatusAsync(Restaurant obj);
    }
}
