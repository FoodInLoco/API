using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Repositories.Interfaces;

namespace FoodInLoco.Application.Data.Repositories
{
    public sealed class MenuRepository : EFRepository<Menu>, IMenuRepository
    {
        public MenuRepository(Context context) : base(context) { }

    }
}
