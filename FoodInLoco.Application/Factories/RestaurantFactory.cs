using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class RestaurantFactory : IRestaurantFactory
    {
        public Restaurant Create(RestaurantModelRequest model)
        {
            return new Restaurant
            (
                new Company(model.CompanyName, model.TradingName),
                new Email(model.Email),
                new Phone(model.DDD, model.PhoneNumber),
                new Address(model.State, model.City, model.ZipCode, model.Street, model.Number, model.Complement),
                model.Kids,
                model.Photo
            );
        }
    }
}
