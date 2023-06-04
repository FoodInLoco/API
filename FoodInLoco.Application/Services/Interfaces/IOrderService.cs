using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IResult<Guid>> AddAsync(OrderModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<IResult<OrderModelResponse?>> GetAsync(Guid id);

        Task<IResult<IEnumerable<OrderModelResponse>>> GetByBillIdAsync(Guid id);

        Task<IResult<IEnumerable<OrderModelResponse>>> ListAsync();

        Task<IResult> UpdateAsync(OrderModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> ConfirmAsync(Guid id);
    }
}
