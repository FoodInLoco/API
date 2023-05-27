using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IBillService
    {
        Task<IResult<Guid>> AddAsync(BillModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<BillModelResponse?> GetAsync(Guid id);

        Task<BillModelResponse?> GetActiveByTableAsync(Guid id);

        Task<IEnumerable<BillModelResponse>> GetActiveByUserAsync(Guid id);

        Task<IEnumerable<BillModelResponse>> ListAsync();

        Task<IResult> UpdateAsync(BillModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
