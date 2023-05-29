using System.ComponentModel;

namespace FoodInLoco.Application.Enums
{
    [Flags]
    public enum Roles
    {
        [Description("User")]
        User = 1,

        [Description("Restaurant")]
        Restaurant = 2
    }
}
