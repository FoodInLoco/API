﻿using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class ReviewExpression
    {
        public static Expression<Func<Review, ReviewModel>> Model => _ => new ReviewModel
        {
            Id = _.Id,
            InsertDate = _.InsertDate,
            UpdateDate = _.UpdateDate,
            RestaurantId = _.RestaurantId,
            ReservationId = _.ReservationId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Rate = _.Rate,
            Status = _.Status
        };

        public static Expression<Func<Review, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }
    }
}