﻿using DotNetCore.Objects;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FoodInLoco.Application.Repositories
{
    public sealed class UserRepository : EFRepository<User>, IUserRepository
    {
        private readonly Context _dbContext;

        public UserRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<UserModel> GetModelByIdAsync(Guid id)
        {
            return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public Task<UserModel> GetModelByIdWithRelationsAsync(Guid id)
        {
            return Queryable.Where(UserExpression.Id(id))
                .Include(_ => _.Restaurants)
                .Include(_ => _.Reservations).ThenInclude(_ => _.Restaurant)
                .Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public Task<UserModel> GetModelByEmailAsync(string email)
        {
            return Queryable.Where(UserExpression.Email(email)).Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public Task<Grid<UserModel>> GridAsync(GridParameters parameters)
        {
            return Queryable.Select(UserExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<UserModel>> ListModelAsync()
        {
            return await Queryable.Select(UserExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(User obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }

        public Task<bool> AnyByEmailAsync(string email)
        {
            return Queryable.AnyAsync(UserExpression.Email(email));
        }

        public Task<User> GetByEmailAsync(string email)
        {
            return Queryable.SingleOrDefaultAsync(UserExpression.Email(email));
        }

    }
}
