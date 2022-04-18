using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class RestaurantExpression
    {
        public static Expression<Func<Restaurant, long>> AuthId => restaurant => restaurant.Auth.Id;

        public static Expression<Func<Restaurant, RestaurantModel>> Model => restaurant => new RestaurantModel
        {
            Id = restaurant.Id,
            CompanyName = restaurant.Company.CompanyName,
            TradingName = restaurant.Company.TradingName,
            Email = restaurant.Email.Value,
            DDD = restaurant.CellPhone.DDD,
            PhoneNumber = restaurant.CellPhone.PhoneNumber
        };

        public static Expression<Func<Restaurant, bool>> Id(long id)
        {
            return restaurant => restaurant.Id == id;
        }
    }
}
