using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Data.Entities;

namespace FoodInLoco.Application.Factories.Interfaces
{
    public interface IReservationFactory
    {
        Reservation Create(ReservationModelRequest model);
    }
}
