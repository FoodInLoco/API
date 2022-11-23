﻿using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class ReservationExpression
    {
        public static Expression<Func<Reservation, ReservationModel>> Model => _ => new ReservationModel
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
            Confirmation = _.Confirmation
        };

        public static Expression<Func<Reservation, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<Reservation, bool>> FromRestaurantByDate(Guid id, DateTime? date)
        {
            return _ => _.RestaurantId == id && _.IsActive() && date.HasValue ? date.Value.Date == _.Date.Date : true;
        }

        public static Expression<Func<Reservation, bool>> FromUserByDate(Guid id, DateTime? date)
        {
            return _ => _.UserId == id && _.IsActive() && date.HasValue ? date.Value.Date == _.Date.Date : true;
        }
    }
}
