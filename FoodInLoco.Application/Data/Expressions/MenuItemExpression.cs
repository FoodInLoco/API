using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class MenuItemExpression
    {
        public static Expression<Func<MenuItem, MenuItemModel>> Model => menuItem => new MenuItemModel
        {
            Id = menuItem.Id,
            MenuId = menuItem.MenuId,
            Name = menuItem.NameDescription.Name,
            Description = menuItem.NameDescription.Description,
            Quantity = menuItem.Quantity,
            Value = menuItem.Value,
            Photo = menuItem.Photo,
            Status = menuItem.Status
        };

        public static Expression<Func<MenuItem, bool>> Id(long id)
        {
            return menuItem => menuItem.Id == id;
        }
    }
}
