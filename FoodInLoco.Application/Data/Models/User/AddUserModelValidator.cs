namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddUserModelValidator : UserModelValidator
    {
        public AddUserModelValidator()
        {
            FirstName(); LastName(); Email(); DDD(); PhoneNumber(); Roles(); Password(); Photo();
        }
    }
}
