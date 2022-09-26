using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class MenuFactory : IMenuFactory
    {
        public Menu Create(MenuModel model)
        {
            throw new NotImplementedException();
            //return new Menu(model.Login, model.Password, (Roles)model.Roles);
        }
    }
}
