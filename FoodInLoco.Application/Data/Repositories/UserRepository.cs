using DotNetCore.EntityFrameworkCore;
using DotNetCore.Objects;
using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Data.Repositories
{
    public sealed class UserRepository : EFRepository<User>, IUserRepository
    {
        private readonly Context _dbContext;

        public UserRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<long> GetAuthIdByUserIdAsync(long id)
        {
            return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.AuthId).SingleOrDefaultAsync();
        }

        public Task<UserModel> GetModelAsync(long id)
        {
            return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public Task<Grid<UserModel>> GridAsync(GridParameters parameters)
        {
            return Queryable.Select(UserExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<UserModel>> ListModelAsync()
        {
            return await Queryable.Select(UserExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(User user)
        {
            return UpdatePartialAsync(new { user.Id, user.Status });
        }

        public async Task<List<User>> GetAsync()
        {
            return await Queryable.Select(Z => Z).ToListAsync();
        }

        //public async Task<User> GetById(long id)
        //{
        //    var user = await _dbContext.User.FindAsync(id);
        //    return user;
        //}

        //public async Task<User> PostAsync(User user)
        //{
        //    _dbContext.User.Add(user);
        //    await _dbContext.SaveChangesAsync();
        //    return await GetById(user.Id);
        //}

        //public async Task<User> PutAsync(User userToUpdate)
        //{
        //    _dbContext.User.Update(userToUpdate);
        //    await _dbContext.SaveChangesAsync();
        //    return await GetById(userToUpdate.Id);
        //}

        //public async Task DeleteAsync(long id)
        //{
        //    var userToDelete = await GetById(id);
        //    if (userToDelete == null)
        //    {
        //        return;
        //    }
        //    _dbContext.User.Remove(userToDelete);
        //    await _dbContext.SaveChangesAsync();
        //}
    }
}
