using FoodInLoco.Application.Enums;
using System.ComponentModel;

namespace FoodInLoco.Application.Extensions
{
    public static class RolesExtensions
    {
        public static string GetRoleName(this Roles role)
        {
            var type = role.GetType();
            var memberInfo = type.GetMember(role.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            var description = ((DescriptionAttribute)attributes[0]).Description;
            return description;
        }
    }
}
