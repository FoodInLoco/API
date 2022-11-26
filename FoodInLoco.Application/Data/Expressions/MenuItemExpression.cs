using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class MenuItemExpression
    {
        public static Expression<Func<MenuItem, MenuItemModelResponse>> Model => _ => new MenuItemModelResponse
        {
            Id = _.Id,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            MenuId = _.MenuId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Quantity = _.Quantity,
            Value = _.Value,
            Photo = _.Photo,
            Status = _.Status
        };

        public static Expression<Func<MenuItem, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<MenuItem, bool>> ItemsByMenu(Guid menuId)
        {
            return _ => _.MenuId == menuId && _.IsActive();
        }
    }
}
