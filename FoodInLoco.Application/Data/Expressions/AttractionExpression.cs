﻿using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class AttractionExpression
    {
        public static Expression<Func<Attraction, AttractionModel>> Model => _ => new AttractionModel
        {
            Id = _.Id,
            InsertDate = _.InsertDate,
            UpdateDate = _.UpdateDate,
            RestaurantId = _.RestaurantId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Photo = _.Photo,
            CoverTax = _.CoverTax,
            Date = _.Date,
            Status = _.Status
        };

        public static Expression<Func<Attraction, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }
    }
}