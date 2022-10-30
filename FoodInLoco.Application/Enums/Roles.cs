namespace FoodInLoco.Application.Data.Enums
{
    [Flags]
    public enum Roles
    {
        None = 0,
        User = 1,
        Admin = 2,
        Restaurant = 4
    }
}