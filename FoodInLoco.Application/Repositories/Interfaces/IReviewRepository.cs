using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<ReviewModelResponse?> GetModelByIdAsync(Guid id);

        Task<ReviewModelResponse?> GetModelByIdWithRelationsAsync(Guid id);

        Task<IEnumerable<ReviewModelResponse>> ListModelAsync();

        Task UpdateStatusAsync(Review obj);
    }
}
