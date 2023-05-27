﻿using DotNetCore.Objects;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Expressions;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.Application.Repositories
{
    public sealed class RestaurantRepository : EFRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(Context context) : base(context) { }

        public async Task<RestaurantModelResponse?> GetModelByIdAsync(Guid id)
        {
            return await Queryable.Where(RestaurantExpression.Id(id)).Select(RestaurantExpression.Model).SingleOrDefaultAsync();
        }
        
        public async Task<RestaurantModelResponse?> GetModelByIdWithRelationsAsync(Guid id)
        {
            return await Queryable.Where(RestaurantExpression.Id(id))
                .Include(_ => _.User)
                .Include(_ => _.Attractions)
                .Include(_ => _.Menus).ThenInclude(_ => _.Items)
                .Include(_ => _.Reservations).ThenInclude(_ => _.User)
                .Include(_ => _.Reviews).ThenInclude(_ => _.User)
                .Select(RestaurantExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<Grid<RestaurantModelResponse>> GridAsync(GridParameters parameters)
        {
            return await Queryable.Select(RestaurantExpression.Model).GridAsync(parameters);
        }

        public async Task<IEnumerable<RestaurantModelResponse>> ListModelAsync()
        {
            return await Queryable.Select(RestaurantExpression.Model).ToListAsync();
        }

        public Task UpdateStatusAsync(Restaurant obj)
        {
            return UpdatePartialAsync(new { obj.Id, obj.Status, LastUpdatedAt = DateTime.UtcNow });
        }
    }
}
