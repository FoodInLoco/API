namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddMenuModelValidator : MenuModelValidator
    {
        public AddMenuModelValidator()
        {
            FirstName(); LastName(); Email(); DDD(); PhoneNumber(); Roles();
        }
    }
}
