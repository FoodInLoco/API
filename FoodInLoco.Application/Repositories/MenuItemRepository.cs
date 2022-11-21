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
    public sealed class MenuItemRepository : EFRepository<MenuItem>, IMenuItemRepository
    {
        private readonly Context _dbContext;

        public MenuItemRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<MenuItemModel> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(MenuItemExpression.Id(id)).Select(MenuItemExpression.Model).SingleOrDefaultAsync();
        }

        public Task<Grid<MenuItemModel>> GridAsync(GridParameters parameters)
        {
            return Queryable.Select(MenuItemExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<MenuItemModel>> ListModelAsync()
        {
            return await Queryable.Select(MenuItemExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(MenuItem obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status });
        }

    }
}
