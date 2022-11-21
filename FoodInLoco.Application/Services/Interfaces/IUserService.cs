using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<IResult<Guid>> AddAsync(UserModel model);

        Task<IResult> DeleteAsync(Guid id);

        Task<UserModel> GetAsync(Guid id);
        
        Task<UserModel> GetByEmail(string email);

        Task<Grid<UserModel>> GridAsync(GridParameters parameters);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IEnumerable<UserModel>> ListAsync();

        Task<IResult> UpdateAsync(UserModel model);

        Task<IResult<TokenModel>> SignInAsync(SignInModel model);
    }
}
