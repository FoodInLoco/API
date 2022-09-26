using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<long> GetAuthIdByUserIdAsync(long id);

        Task<UserModel> GetModelByIdAsync(long id);

        Task<Grid<UserModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<UserModel>> ListModelAsync();

        Task UpdateStatusAsync(User user);
    }
}
