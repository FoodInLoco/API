using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<RestaurantModel> GetModelByIdAsync(Guid id);

        Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<RestaurantModel>> ListModelAsync();

        Task UpdateStatusAsync(Restaurant obj);
    }
}
