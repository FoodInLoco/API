using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;
using System.Linq;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class RestaurantExpression
    {
        public static Expression<Func<Restaurant, RestaurantModelResponse>> Model => _ => new RestaurantModelResponse
        {
            Id = _.Id,
            UserId = _.UserId,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            CompanyName = _.Company.CompanyName,
            TradingName = _.Company.TradingName,
            Email = _.Email.Value,
            DDD = _.CellPhone.DDD,
            PhoneNumber = _.CellPhone.PhoneNumber,
            State = _.Address.State,
            City = _.Address.City,
            ZipCode = _.Address.ZipCode,
            Street = _.Address.Street,
            Number = _.Address.Number,
            Complement = _.Address.Complement,
            Status = _.Status,
            Kids = _.Kids,
            Photo = _.Photo,
            User = _.User,
            Menus = _.Menus.Select(_ => (MenuModelResponse)_).ToList(),
            Reservations = _.Reservations.Select(_ => (ReservationModelResponse)_).ToList(),
            Attractions = _.Attractions.Select(_ => (AttractionModelResponse)_).ToList(),
            Reviews = _.Reviews.Select(_ => (ReviewModelResponse)_).ToList()
        };

        public static Expression<Func<Restaurant, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Restaurant, bool>> Email(string email)
        {
            return _ => _.Email.Value == email;
        }
    }
}
