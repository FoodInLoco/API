using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Data.Repositories.Interfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<long> GetAuthIdByRestaurantIdAsync(long id);

        Task<RestaurantModel> GetModelByIdAsync(long id);

        Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<RestaurantModel>> ListModelAsync();

        Task UpdateStatusAsync(Restaurant user);
    }
}
