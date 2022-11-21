using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<ReviewModel> GetModelByIdAsync(Guid id);

        Task<IEnumerable<ReviewModel>> ListModelAsync();

        Task UpdateStatusAsync(Review obj);
    }
}
