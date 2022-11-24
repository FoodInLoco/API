namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddAttractionModelValidator : AttractionModelValidator
    {
        public AddAttractionModelValidator()
        {
            Restaurant(); Name(); Description(); Date(); Cover(); Photo();
        }
    }
}
