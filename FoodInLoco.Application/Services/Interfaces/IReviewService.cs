using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IReviewService
    {
        Task<IResult<Guid>> AddAsync(ReviewModel model);

        Task<IResult> DeleteAsync(Guid id);

        Task<ReviewModel> GetAsync(Guid id);
        
        Task<IEnumerable<ReviewModel>> ListAsync();

        Task<IResult> UpdateAsync(ReviewModel model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
