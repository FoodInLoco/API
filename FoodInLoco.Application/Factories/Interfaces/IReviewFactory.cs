using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Factories.Interfaces
{
    public interface IReviewFactory
    {
        Review Create(ReviewModelRequest model);
    }
}
