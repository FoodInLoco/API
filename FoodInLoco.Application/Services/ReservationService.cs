using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReservationRepository _reservationRepository;
        private readonly IReservationFactory _reservationFactory;

        public ReservationService
        (
            IUnitOfWork unitOfWork,
            IReservationRepository reservationRepository,
            IReservationFactory reservationFactory
        )
        {
            _unitOfWork = unitOfWork;
            _reservationRepository = reservationRepository;
            _reservationFactory = reservationFactory;
        }

        public async Task<bool> CheckUser(Guid reservationId, Guid userId)
        {
            var reservation = await _reservationRepository.GetAsync(reservationId);

            return reservation.UserId == userId;
        }

        public async Task<IResult<Guid>> AddAsync(Guid userId, ReservationModelRequest model)
        {
            var validation = new AddReservationModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var restaurant = _reservationFactory.Create(userId, model);

            await _reservationRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _reservationRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult<ReservationModelResponse?>> GetAsync(Guid id)
        {
            var response = await _reservationRepository.GetModelByIdWithRelationsAsync(id);
            return response.Success();
        }

        public async Task<IResult<IEnumerable<ReservationModelResponse>>> ListAsync()
        {
            var response = await _reservationRepository.ListModelAsync();
            return response.Success();
        }

        public async Task<IResult<IEnumerable<ReservationModelResponse>>> ListByDateFromRestaurantAsync(Guid restaurantId, DateTime? date)
        {
            var response = await _reservationRepository.ListModelByDateFromRestaurantAsync(restaurantId, date);
            return response.Success();
        }
        
        public async Task<IResult<IEnumerable<ReservationModelResponse>>> ListByDateFromUserAsync(Guid userId, DateTime? date)
        {
            var response = await _reservationRepository.ListModelByDateFromUserAsync(userId, date);
            return response.Success();
        }
        
        public async Task<IResult<IEnumerable<ReservationModelResponse>>> ListPendingConfirmationAsync()
        {
            var response = await _reservationRepository.ListModelPendingConfirmationAsync();
            return response.Success();
        }

        public async Task<IResult> UpdateAsync(ReservationModelRequest model)
        {
            var validation = new UpdateReservationModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var reservation = await _reservationRepository.GetAsync(model.Id);

            if (reservation is null)
                return Result.Success();

            reservation.Update(model.Description, model.SeatQuantity, model.Date);

            await _reservationRepository.UpdateAsync(reservation);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var obj = new Reservation(id);
            obj.Inactivate();

            await _reservationRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var obj = new Reservation(id);
            obj.Activate();

            await _reservationRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> DisconfirmAsync(Guid id)
        {
            var obj = new Reservation(id);
            obj.Disconfirm();

            await _reservationRepository.UpdateConfirmationAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ConfirmAsync(Guid id)
        {
            var obj = new Reservation(id);
            obj.Confirm();

            await _reservationRepository.UpdateConfirmationAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
