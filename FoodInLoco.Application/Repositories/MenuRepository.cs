using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;

namespace FoodInLoco.Application.Repositories
{
    public sealed class MenuRepository : EFRepository<Menu>, IMenuRepository
    {
        private readonly Context _dbContext;

        public MenuRepository(Context context) : base(context)
        {
            _dbContext = context;
        }

        public Task<MenuModel> GetModelByIdAsync(long id)
        {
            return Queryable.Where(MenuExpression.Id(id)).Select(MenuExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<MenuModel>> ListModelAsync()
        {
            return await Queryable.Select(MenuExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Menu menu)
        {
            return UpdatePartialAsync(new { menu.Id, menu.Status });
        }
    }
}
