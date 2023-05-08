namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateTableModelValidator : TableModelValidator
    {
        public UpdateTableModelValidator()
        {
            Id(); Restaurant(); Number();
        }
    }
}
