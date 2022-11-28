using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;
using FoodInLoco.Application.Enums;

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
            RestaurantName = _.Restaurant.Company.CompanyName,
            Items = _.Items.Select(_ => (MenuItemModelResponse)_).ToList()
        };

        public static Expression<Func<Menu, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Menu, bool>> FromRestaurant(Guid restaurantId)
        {
            return _ => _.RestaurantId == restaurantId; //&& _.Status == Status.Active && !(!_.ExpirationDate.HasValue || _.ExpirationDate.Value.CompareTo(DateTime.Now) <= 0);
        }
    }
}
