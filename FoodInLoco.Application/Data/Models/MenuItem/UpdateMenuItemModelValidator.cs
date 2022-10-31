namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateMenuItemModelValidator : MenuItemModelValidator
    {
        public UpdateMenuItemModelValidator()
        {
            Id(); FirstName(); LastName(); Email(); DDD(); PhoneNumber();
        }
    }
}
