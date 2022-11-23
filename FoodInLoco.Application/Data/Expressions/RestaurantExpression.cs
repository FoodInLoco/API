using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class RestaurantExpression
    {
        public static Expression<Func<Restaurant, RestaurantModel>> Model => _ => new RestaurantModel
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
            Photo = _.Photo
        };

        public static Expression<Func<Restaurant, RestaurantModel>> ModelWithRelations => _ => new RestaurantModel
        {
            Id = _.Id,
            UserId =_.UserId,
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
            //Menus = _.Menus.ToModelList()
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
