using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IAttractionService
    {
        Task<IResult<long>> AddAsync(AttractionModel model);

        Task<IResult> DeleteAsync(long id);

        Task<AttractionModel> GetAsync(long id);

        Task<IEnumerable<AttractionModel>> ListAsync();

        Task<IResult> UpdateAsync(AttractionModel model);

        Task<IResult> InactivateAsync(long id);

        Task<IResult> ActivateAsync(long id);
    }
}
