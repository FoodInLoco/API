using DotNetCore.Objects;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
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

        public Task<RestaurantModel> GetModelByIdAsync(long id)
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
    }
}
