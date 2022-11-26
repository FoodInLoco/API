using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

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
            User = _.User
        };

        public static Expression<Func<Reservation, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Reservation, bool>> FromRestaurantByDate(Guid restaurantId, DateTime? date)
        {
            return _ => _.RestaurantId == restaurantId && _.IsActive() && date.HasValue ? date.Value.Date == _.Date.Date : true;
        }

        public static Expression<Func<Reservation, bool>> FromUserByDate(Guid userId, DateTime? date)
        {
            return _ => _.UserId == userId && _.IsActive() && date.HasValue ? date.Value.Date == _.Date.Date : true;
        }
    }
}
