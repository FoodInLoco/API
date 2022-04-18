using DotNetCore.EntityFrameworkCore;
using DotNetCore.Objects;
using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data.Repositories
{
    public sealed class RestaurantRepository : EFRepository<Restaurant>, IRestaurantRepository
    {
        private readonly Context _dbContext;

        public RestaurantRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<long> GetAuthIdByRestaurantIdAsync(long id)
        {
            return Queryable.Where(RestaurantExpression.Id(id)).Select(RestaurantExpression.AuthId).SingleOrDefaultAsync();
        }

        public Task<RestaurantModel> GetModelAsync(long id)
        {
            return Queryable.Where(RestaurantExpression.Id(id)).Select(RestaurantExpression.Model).SingleOrDefaultAsync();
        }

        public Task<Grid<RestaurantModel>> GridAsync(GridParameters parameters)
        {
            return Queryable.Select(RestaurantExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<RestaurantModel>> ListModelAsync()
        {
            return await Queryable.Select(RestaurantExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Restaurant user)
        {
            return UpdatePartialAsync(new { user.Id, user.Status });
        }

        public async Task<List<Restaurant>> GetAsync()
        {
            var restaurants = await Queryable.ToListAsync();
            return restaurants;
        }

        //public async Task<Restaurant> GetById(long id)
        //{
        //    var restaurant = await _dbContext.Restaurant.FindAsync(id);
        //    return restaurant;
        //}

        //public async Task<Restaurant> PostAsync(Restaurant restaurant)
        //{
        //    _dbContext.Restaurant.Add(restaurant);
        //    await _dbContext.SaveChangesAsync();
        //    return await GetById(restaurant.Id);
        //}

        //public async Task<Restaurant> PutAsync(Restaurant restaurantToUpdate)
        //{
        //    _dbContext.Restaurant.Update(restaurantToUpdate);
        //    await _dbContext.SaveChangesAsync();
        //    return await GetById(restaurantToUpdate.Id);
        //}

        //public async Task DeleteAsync(long id)
        //{
        //    var restaurantToDelete = await GetById(id);
        //    if (restaurantToDelete == null)
        //    {
        //        return;
        //    }
        //    _dbContext.Restaurant.Remove(restaurantToDelete);
        //    await _dbContext.SaveChangesAsync();
        //}
    }
}
