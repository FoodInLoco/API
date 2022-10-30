using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class MenuItemFactory : IMenuItemFactory
    {
        public MenuItem Create(MenuItemModel model)
        {
            throw new NotImplementedException();
            //return new MenuItem(model.Login, model.Password, (Roles)model.Roles);
        }
    }
}
