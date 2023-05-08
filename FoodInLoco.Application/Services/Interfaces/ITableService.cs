using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface ITableService
    {
        Task<IResult<Guid>> AddAsync(TableModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<TableModelResponse?> GetAsync(Guid id);
        
        Task<IEnumerable<TableModelResponse>> ListAsync();

        Task<IResult> UpdateAsync(TableModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);
    }
}
