namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddReservationModelValidator : ReservationModelValidator
    {
        public AddReservationModelValidator()
        {
            Restaurant(); User(); Description(); SeatQuantity(); Date();
        }
    }
}
