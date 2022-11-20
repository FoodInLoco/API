﻿using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class MenuItemExpression
    {
        public static Expression<Func<MenuItem, MenuItemModel>> Model => _ => new MenuItemModel
        {
            Id = _.Id,
            MenuId = _.MenuId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Quantity = _.Quantity,
            Value = _.Value,
            Photo = _.Photo,
            Status = _.Status
        };

        public static Expression<Func<MenuItem, bool>> Id(long id)
        {
            return _ => _.Id == id;
        }
    }
}
