namespace FoodInLoco.Application.Data.Models
{
    public sealed class AddReservationModelValidator : ReservationModelValidator
    {
        public AddReservationModelValidator()
        {
            Restaurant(); Description(); SeatQuantity(); Date();
        }
    }
}
