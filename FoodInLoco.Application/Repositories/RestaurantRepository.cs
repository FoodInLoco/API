using DotNetCore.Objects;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FoodInLoco.Application.Repositories
{
    public sealed class RestaurantRepository : EFRepository<Restaurant>, IRestaurantRepository
    {
        private readonly Context _dbContext;

        public RestaurantRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<RestaurantModel> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(RestaurantExpression.Id(id)).Select(RestaurantExpression.Model).SingleOrDefaultAsync();
        }
        
        public Task<RestaurantModel> GetModelByIdWithRelationsAsync(Guid id)
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

        public Task UpdateStatusAsync(Restaurant obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
