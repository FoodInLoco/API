namespace FoodInLoco.Application.Data.Models
{
    public sealed class UpdateAttractionModelValidator : AttractionModelValidator
    {
        public UpdateAttractionModelValidator()
        {
            Id(); Restaurant(); Name(); Description(); Photo(); Date();
        }
    }
}
