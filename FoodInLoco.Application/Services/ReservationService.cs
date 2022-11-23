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

        public async Task<IResult<Guid>> AddAsync(ReservationModel model)
        {
            var validation = new AddReservationModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var restaurant = _reservationFactory.Create(model);

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

        public Task<ReservationModel> GetAsync(Guid id)
        {
            return _reservationRepository.GetModelByIdWithRelationsAsync(id);
        }

        public async Task<IEnumerable<ReservationModel>> ListAsync()
        {
            return await _reservationRepository.ListModelAsync();
        }

        public async Task<IEnumerable<ReservationModel>> ListByDateFromRestaurantAsync(Guid id, DateTime? date)
        {
            return await _reservationRepository.ListModelByDateFromRestaurantAsync(id, date);
        }
        
        public async Task<IEnumerable<ReservationModel>> ListByDateFromUserAsync(Guid id, DateTime? date)
        {
            return await _reservationRepository.ListModelByDateFromUserAsync(id, date);
        }

        public async Task<IResult> UpdateAsync(ReservationModel model)
        {
            var validation = new UpdateReservationModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var attraction = await _reservationRepository.GetAsync(model.Id);

            if (attraction is null)
                return Result.Success();

            attraction.Update(model.Description, model.SeatQuantity, model.Date);

            await _reservationRepository.UpdateAsync(attraction);

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

            await _reservationRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ConfirmAsync(Guid id)
        {
            var obj = new Reservation(id);
            obj.Confirm();

            await _reservationRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
