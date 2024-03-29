using DotNetCore.Objects;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class MenuItemRepository : EFRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(Context context) : base(context) { }

        public async Task<MenuItemModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(MenuItemExpression.Id(id))
                .Include(_ => _.Menu)
                .Select(MenuItemExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<Grid<MenuItemModelResponse>> GridAsync(GridParameters parameters)
        {
            return await Queryable.Select(MenuItemExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<MenuItemModelResponse>> ListModelAsync()
        {
            return await Queryable.Select(MenuItemExpression.Model).ToListAsync();
        }
        
        public async Task<IEnumerable<MenuItemModelResponse>> ListModelByMenuAsync(Guid menuId)
        {
            return await Queryable.Where(MenuItemExpression.ItemsByMenu(menuId)).Select(MenuItemExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(MenuItem obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }

    }
}
