using DotNetCore.Objects;
using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Data.Repositories.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<long> GetAuthIdByRestaurantIdAsync(long id);

        Task<RestaurantModel> GetModelAsync(long id);

        Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<RestaurantModel>> ListModelAsync();

        Task UpdateStatusAsync(Restaurant user);

        //Task<List<Restaurant>> GetAsync();
        //Task<Restaurant> GetById(long id);
        //Task<Restaurant> PostAsync(Restaurant restaurant);
        //Task<Restaurant> PutAsync(Restaurant restaurantToUpdate);
        //Task DeleteAsync(long id);
    }
}
