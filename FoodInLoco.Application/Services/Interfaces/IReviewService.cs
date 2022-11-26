using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IReviewService
    {
        Task<bool> CheckUser(Guid reviewId, Guid userId);

        Task<IResult<Guid>> AddAsync(Guid userId, ReviewModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<ReviewModelResponse> GetAsync(Guid id);
        
        Task<IEnumerable<ReviewModelResponse>> ListAsync();

        Task<IResult> UpdateAsync(ReviewModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
