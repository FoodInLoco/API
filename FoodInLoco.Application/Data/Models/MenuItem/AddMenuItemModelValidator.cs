namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddMenuItemModelValidator : MenuItemModelValidator
    {
        public AddMenuItemModelValidator()
        {
            FirstName(); LastName(); Email(); DDD(); PhoneNumber(); Roles();
        }
    }
}
