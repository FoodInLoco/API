using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IBillService
    {
        Task<IResult<Guid>> AddAsync(BillModelRequest model, Guid userId);

        Task<IResult<Guid>> AddUserAsync(BillUserModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<IResult<BillModelResponse?>> GetAsync(Guid id);

        Task<IResult<BillModelResponse?>> GetActiveByTableAsync(Guid id);

        Task<IResult<IEnumerable<BillModelResponse>>> GetActiveByUserAsync(Guid id);

        Task<IResult<IEnumerable<UserModelResponse>?>> GetUserPendingAsync(Guid id);

        Task<IResult<IEnumerable<BillModelResponse>>> ListAsync();

        Task<IResult> UpdateAsync(BillModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> DeclineUserAsync(BillUserModelRequest model);

        Task<IResult> AcceptUserAsync(BillUserModelRequest model);
    }
}
