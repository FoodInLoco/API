using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class RestaurantExpression
    {
        public static Expression<Func<Restaurant, RestaurantModel>> Model => restaurant => new RestaurantModel
        {
            Id = restaurant.Id,
            CompanyName = restaurant.Company.CompanyName,
            TradingName = restaurant.Company.TradingName,
            Email = restaurant.Email.Value,
            DDD = restaurant.CellPhone.DDD,
            PhoneNumber = restaurant.CellPhone.PhoneNumber,
            State = restaurant.Address.State,
            City = restaurant.Address.City,
            ZipCode = restaurant.Address.ZipCode,
            Street = restaurant.Address.Street,
            Number = restaurant.Address.Number,
            Complement = restaurant.Address.Complement
        };

        public static Expression<Func<Restaurant, bool>> Id(long id)
        {
            return restaurant => restaurant.Id == id;
        }
    }
}
