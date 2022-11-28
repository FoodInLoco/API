using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;
using FoodInLoco.Application.Enums;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class ReservationExpression
    {
        public static Expression<Func<Reservation, ReservationModelResponse>> Model => _ => new ReservationModelResponse
        {
            Id = _.Id,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            RestaurantId = _.RestaurantId,
            UserId = _.UserId,
            Description = _.Description,
            SeatQuantity = _.SeatQuantity,
            Date = _.Date,
            Status = _.Status,
            Confirmation = _.Confirmation,
            UserName = _.User.Name.FirstName,
            UserEmail = _.User.Email.Value,
            RestaurantName = _.Restaurant.Company.CompanyName
        };

        public static Expression<Func<Reservation, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Reservation, bool>> FromRestaurantByDate(Guid restaurantId, DateTime? date)
        {
            return _ => _.RestaurantId == restaurantId && (!date.HasValue || (date.Value.Day == _.Date.Day && date.Value.Month == _.Date.Month && date.Value.Year == _.Date.Year)); //&& _.Status == Status.Active && _.Confirmation == Status.Active;
        }

        public static Expression<Func<Reservation, bool>> FromUserByDate(Guid userId, DateTime? date)
        {
            return _ => _.UserId == userId && (!date.HasValue || (date.Value.Day == _.Date.Day && date.Value.Month == _.Date.Month && date.Value.Year == _.Date.Year)); //&& _.Status == Status.Active && _.Confirmation == Status.Active;
        }

        public static Expression<Func<Reservation, bool>> PendingConfirmation()
        {
            return _ => _.Status == Status.Active && _.Confirmation == Status.None;
        }
    }
}
