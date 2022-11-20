using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class MenuFactory : IMenuFactory
    {
        public Menu Create(MenuModel model)
        {
            return new Menu
            (
                model.RestaurantId,
                new NameDescription(model.Name, model.Description),
                model.Photo,
                model.InitialDate,
                model.ExpirationDate,
                new HappyHour(model.HappyHour, model.StartAt, model.EndAt)
            );
        }
    }
}
