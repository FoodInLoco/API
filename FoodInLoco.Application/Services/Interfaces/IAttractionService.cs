using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IAttractionService
    {
        Task<IResult<Guid>> AddAsync(AttractionModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<IResult<AttractionModelResponse?>> GetAsync(Guid id);
        
        Task<IResult<IEnumerable<AttractionModelResponse>>> ListAsync();

        Task<IResult> UpdateAsync(AttractionModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
