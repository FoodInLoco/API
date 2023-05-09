using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IResult<Guid>> AddAsync(OrderModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<OrderModelResponse?> GetAsync(Guid id);
        
        Task<IEnumerable<OrderModelResponse>> ListAsync();

        Task<IResult> UpdateAsync(OrderModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
