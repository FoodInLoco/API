using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<bool> CheckUser(Guid restaurantId, Guid userId);

        Task<IResult<Guid>> AddAsync(RestaurantModelRequest model);

        Task<IResult<IEnumerable<RestaurantModelResponse>>> ListAsync();

        Task<IResult<RestaurantModelResponse?>> GetAsync(Guid id);

        Task<IResult> GetByEmail(string email);

        Task<IResult<Grid<RestaurantModelResponse>>> GridAsync(GridParameters parameters);

        Task<IResult> UpdateAsync(RestaurantModelRequest model);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult> DeleteAsync(Guid id);

        Task<IResult<TokenModel<RestaurantTokenModel>>> SignInAsync(SignInModel model);
    }
}
