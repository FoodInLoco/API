namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddMenuModelValidator : MenuModelValidator
    {
        public AddMenuModelValidator()
        {
            Restaurant(); Name(); Description(); InitialDate(); HappyHour();
        }
    }
}
