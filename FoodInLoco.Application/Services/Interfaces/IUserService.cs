using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<IResult<long>> AddAsync(UserModel model);

        Task<IResult> DeleteAsync(long id);

        Task<UserModel> GetAsync(long id);
        
        Task<UserModel> GetByEmail(string email);

        Task<Grid<UserModel>> GridAsync(GridParameters parameters);

        Task<IResult> InactivateAsync(long id);

        Task<IResult> ActivateAsync(long id);

        Task<IEnumerable<UserModel>> ListAsync();

        Task<IResult> UpdateAsync(UserModel model);

        Task<IResult<TokenModel>> SignInAsync(SignInModel model);
    }
}
