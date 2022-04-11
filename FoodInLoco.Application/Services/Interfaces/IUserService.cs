using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Contracts.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<IResult<long>> AddAsync(UserModel model);

        Task<IResult> DeleteAsync(long id);

        Task<UserModel> GetAsync(long id);

        Task<Grid<UserModel>> GridAsync(GridParameters parameters);

        Task<IResult> InactivateAsync(long id);

        Task<IEnumerable<UserModel>> ListAsync();

        Task<IResult> UpdateAsync(UserModel model);
    }
}
