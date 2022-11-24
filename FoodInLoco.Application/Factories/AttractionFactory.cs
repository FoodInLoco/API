using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class AttractionFactory : IAttractionFactory
    {
        public Attraction Create(AttractionModelRequest model)
        {
            return new Attraction
            (
                model.RestaurantId,
                new NameDescription(model.Name, model.Description),
                model.Photo,
                model.Date,
                model.CoverTax
            );
        }
    }
}
