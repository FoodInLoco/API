namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateMenuModelValidator : MenuModelValidator
    {
        public UpdateMenuModelValidator()
        {
            Id(); FirstName(); LastName(); Email(); DDD(); PhoneNumber();
        }
    }
}
