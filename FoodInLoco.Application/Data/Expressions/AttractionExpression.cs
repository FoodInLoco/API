using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class AttractionExpression
    {
        public static Expression<Func<Attraction, AttractionModel>> Model => _ => new AttractionModel
        {
            Id = _.Id,
            RestaurantId = _.RestaurantId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Photo = _.Photo,
            CoverTax = _.CoverTax,
            Date = _.Date,
            Status = _.Status
        };

        public static Expression<Func<Attraction, bool>> Id(long id)
        {
            return _ => _.Id == id;
        }
    }
}
