using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Repositories.Interfaces;

namespace FoodInLoco.Application.Repositories
{
    public sealed class MenuRepository : EFRepository<Menu>, IMenuRepository
    {
        public MenuRepository(Context context) : base(context) { }

    }
}
