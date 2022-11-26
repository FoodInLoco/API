using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Factories.Interfaces
{
    public interface IReviewFactory
    {
        Review Create(Guid userId, ReviewModelRequest model);
    }
}
