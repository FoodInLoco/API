using DotNetCore.Objects;
using DotNetCore.Repositories;
using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<long> GetAuthIdByUserIdAsync(long id);

        Task<UserModel> GetModelAsync(long id);

        Task<Grid<UserModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<UserModel>> ListModelAsync();

        Task UpdateStatusAsync(User user);

        Task<List<User>> GetAsync();
        Task<User> GetById(long id);
        Task<User> PostAsync(User user);
        Task<User> PutAsync(User userToUpdate);
        Task DeleteAsync(long id);
    }
}
