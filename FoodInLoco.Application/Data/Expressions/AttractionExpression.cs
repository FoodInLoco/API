using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class AttractionExpression
    {
        public static Expression<Func<Attraction, AttractionModelResponse>> Model => _ => new AttractionModelResponse
        {
            Id = _.Id,
            CreatedAt = _.CreatedAt,
            LastUpdatedAt = _.LastUpdatedAt,
            RestaurantId = _.RestaurantId,
            Name = _.NameDescription.Name,
            Description = _.NameDescription.Description,
            Photo = _.Photo,
            CoverTax = _.CoverTax,
            Date = _.Date,
            Status = _.Status,
            RestaurantName = _.Restaurant.Company.CompanyName
        };

        public static Expression<Func<Attraction, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }
    }
}
