using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class MenuExpression
    {
        public static Expression<Func<Menu, MenuModel>> Model => menu => new MenuModel
        {
            Id = menu.Id,
            RestaurantId = menu.RestaurantId,
            Name = menu.NameDescription.Name,
            Description = menu.NameDescription.Description,
            Photo = menu.Photo,
            InitialDate = menu.InitialDate,
            ExpirationDate = menu.ExpirationDate,
            HappyHour = menu.HappyHour.Value,
            StartAt = menu.HappyHour.StartAt,
            EndAt = menu.HappyHour.EndAt,
            Status = menu.Status
        };

        public static Expression<Func<Menu, bool>> Id(long id)
        {
            return menu => menu.Id == id;
        }
    }
}
