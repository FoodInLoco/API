using DotNetCore.Objects;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;

namespace FoodInLoco.Application.Repositories
{
    public sealed class MenuItemRepository : EFRepository<MenuItem>, IMenuItemRepository
    {
        private readonly Context _dbContext;

        public MenuItemRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<MenuItemModel> GetModelByIdAsync(long id)
        {
            return Queryable.Where(MenuItemExpression.Id(id)).Select(MenuItemExpression.Model).SingleOrDefaultAsync();
        }

        public Task<Grid<MenuModel>> GridAsync(GridParameters parameters)
        {
            return Queryable.Select(MenuItemExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<MenuModel>> ListModelAsync()
        {
            return await Queryable.Select(MenuItemExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Menu menu)
        {
            return UpdatePartialAsync(new { menu.Id, menu.Status });
        }

    }
}
