namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddTableModelValidator : TableModelValidator
    {
        public AddTableModelValidator()
        {
            Restaurant(); Number();
        }
    }
}
