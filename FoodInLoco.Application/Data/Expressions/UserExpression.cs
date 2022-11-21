using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;
using System.Linq.Expressions;

namespace FoodInLoco.Application.Data.Expressions
{
    public static class UserExpression
    {
        public static Expression<Func<User, UserModel>> Model => _ => new UserModel
        {
            Id = _.Id,
            InsertDate = _.InsertDate,
            UpdateDate = _.UpdateDate,
            FirstName = _.Name.FirstName,
            LastName = _.Name.LastName,
            Email = _.Email.Value,
            DDD = _.CellPhone.DDD,
            PhoneNumber = _.CellPhone.PhoneNumber,
            Roles = _.Roles,
            Photo = _.Photo
        };

        public static Expression<Func<User, bool>> Id(Guid id)
        {
            return _ => _.Id == id;
        }

        public static Expression<Func<User, bool>> Email(string email)
        {
            return _ => _.Email.Value == email;
        }
    }
}
