using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IAttractionService
    {
        Task<IResult<Guid>> AddAsync(AttractionModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<AttractionModelResponse> GetAsync(Guid id);
        
        Task<IEnumerable<AttractionModelResponse>> ListAsync();

        Task<IResult> UpdateAsync(AttractionModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
