using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class MenuRepository : EFRepository<Menu>, IMenuRepository
    {
        public MenuRepository(Context context) : base(context) { }

        public async Task<MenuModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(MenuExpression.Id(id)).Select(MenuExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<MenuModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(MenuExpression.Id(id))
                .Include(_ => _.Items)
                .Include(_ => _.Restaurant)
                .Select(MenuExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<MenuModelResponse>> ListModelAsync()
        {
            return await Queryable.Select(MenuExpression.Model).ToListAsync();
        }
        
        public async Task<IEnumerable<MenuModelResponse>> ListModelByRestaurantAsync(Guid restaurantId)
        {
            return await Queryable.Where(MenuExpression.FromRestaurant(restaurantId)).Select(MenuExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Menu obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
