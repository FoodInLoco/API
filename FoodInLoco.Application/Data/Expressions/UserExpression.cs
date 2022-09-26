using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class UserExpression
    {
        public static Expression<Func<User, long>> AuthId => user => user.Auth.Id;

        public static Expression<Func<User, UserModel>> Model => user => new UserModel
        {
            Id = user.Id,
            FirstName = user.Name.FirstName,
            LastName = user.Name.LastName,
            Email = user.Email.Value,
            DDD = user.CellPhone.DDD,
            PhoneNumber = user.CellPhone.PhoneNumber
        };

        public static Expression<Func<User, bool>> Id(long id)
        {
            return user => user.Id == id;
        }
    }
}
