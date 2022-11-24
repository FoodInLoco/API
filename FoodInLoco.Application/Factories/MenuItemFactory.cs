using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class MenuItemFactory : IMenuItemFactory
    {
        public MenuItem Create(MenuItemModelRequest model)
        {
            return new MenuItem
            (
                model.MenuId,
                new NameDescription(model.Name, model.Description),
                model.Photo,
                model.Quantity,
                model.Value
            );
        }
    }
}
