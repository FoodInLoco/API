using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Repositories.Interfaces;

namespace FoodInLoco.Application.Data.Repositories
{
    public sealed class MenuItemRepository : EFRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(Context context) : base(context) { }

    }
}
