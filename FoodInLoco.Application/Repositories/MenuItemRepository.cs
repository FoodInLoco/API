using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Repositories.Interfaces;

namespace FoodInLoco.Application.Repositories
{
    public sealed class MenuItemRepository : EFRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(Context context) : base(context) { }

    }
}
