using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class MenuExpression
    {
        public static Expression<Func<Menu, MenuModel>> Model => _ => new MenuModel
        {
            Id = _.Id,
            InsertDate = _.InsertDate,
            UpdateDate = _.UpdateDate,
            RestaurantId = _.RestaurantId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Photo = _.Photo,
            InitialDate = _.InitialDate,
            ExpirationDate = _.ExpirationDate,
            HappyHour = _.HappyHour.Value,
            StartAt = _.HappyHour.StartAt,
            EndAt = _.HappyHour.EndAt,
            Status = _.Status
        };

        public static Expression<Func<Menu, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }
    }
}
