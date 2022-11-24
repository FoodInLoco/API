using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<IResult<Guid>> AddAsync(RestaurantModelRequest model);

        Task<IEnumerable<RestaurantModelResponse>> ListAsync();

        Task<RestaurantModelResponse> GetAsync(Guid id);
        
        Task<Grid<RestaurantModelResponse>> GridAsync(GridParameters parameters);

        Task<IResult> UpdateAsync(RestaurantModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> DeleteAsync(Guid id);
    }
}
