using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.ValueObjects;
using FoodInLoco.Application.Enums;
using FoodInLoco.Application.Factories.Interfaces;

namespace FoodInLoco.Application.Factories
{
    public sealed class ReviewFactory : IReviewFactory
    {
        public Review Create(ReviewModelRequest model)
        {
            return new Review
            (
                model.RestaurantId,
                model.ReservationId,
                model.UserId,
                new NameDescription(model.Name, model.Description),
                model.Rate
            );
        }
    }
}
