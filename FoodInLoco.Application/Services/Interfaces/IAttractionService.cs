using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IAttractionService
    {
        Task<IResult<Guid>> AddAsync(AttractionModel model);

        Task<IResult> DeleteAsync(Guid id);

        Task<AttractionModel> GetAsync(Guid id);
        
        Task<IEnumerable<AttractionModel>> ListAsync();

        Task<IResult> UpdateAsync(AttractionModel model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
