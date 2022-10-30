using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<UserModel> GetModelByIdAsync(long id);
        
        Task<UserModel> GetModelByEmailAsync(string email);

        Task<Grid<UserModel>> GridAsync(GridParameters parameters);

        Task<IEnumerable<UserModel>> ListModelAsync();

        Task UpdateStatusAsync(User user);

        Task<bool> AnyByEmailAsync(string email);

        Task<User> GetByEmailAsync(string email);
    }
}
