using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<IResult<Auth>> AddAsync(AuthModel model);

        Task DeleteAsync(long id);

        Task<IResult<TokenModel>> SignInAsync(SignInModel model);
    }
}
