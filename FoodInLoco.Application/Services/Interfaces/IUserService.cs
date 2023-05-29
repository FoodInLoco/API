using DotNetCore.Objects;
using DotNetCore.Results;
using FoodInLoco.Application.Data.Models;

namespace FoodInLoco.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<IResult<Guid>> AddAsync(UserModelRequest model);

        Task<IResult> DeleteAsync(Guid id);

        Task<IResult> GetAsync(Guid id);
        
        Task<IResult> GetByEmail(string email);

        Task<IResult<Grid<UserModelResponse>>> GridAsync(GridParameters parameters);

        Task<IResult> InactivateAsync(Guid id);

        Task<IResult> ActivateAsync(Guid id);

        Task<IResult<IEnumerable<UserModelResponse>>> ListAsync();

        Task<IResult> UpdateAsync(UserModelRequest model);

        Task<IResult<TokenModel<UserTokenModel>>> SignInAsync(SignInModel model);
    }
}
