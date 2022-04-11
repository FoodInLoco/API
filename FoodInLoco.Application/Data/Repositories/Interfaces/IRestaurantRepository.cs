using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Data.Repositories.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<List<Restaurant>> GetAsync();
        Task<Restaurant> GetById(long id);
        Task<Restaurant> PostAsync(Restaurant restaurant);
        Task<Restaurant> PutAsync(Restaurant restaurantToUpdate);
        Task DeleteAsync(long id);
    }
}
