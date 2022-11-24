using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class MenuExpression
    {
        public static Expression<Func<Menu, MenuModelResponse>> Model => _ => new MenuModelResponse
        {
            Id = _.Id,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            RestaurantId = _.RestaurantId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Photo = _.Photo,
            InitialDate = _.InitialDate,
            ExpirationDate = _.ExpirationDate,
            HappyHour = _.HappyHour.Value,
            StartAt = _.HappyHour.StartAt.ToString(),
            EndAt = _.HappyHour.EndAt.ToString(),
            Status = _.Status,
            Items = _.Items.Select(_ => (MenuItemModelResponse)_).ToList()
        };

        public static Expression<Func<Menu, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Menu, bool>> FromRestaurant(Guid id)
        {
            return _ => _.RestaurantId == id && _.IsActive();
        }
    }
}
