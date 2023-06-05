using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Enums;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Repositories;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FoodInLoco.Application.Services
{
    public sealed class BillService : IBillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBillRepository _billRepository;
        private readonly IBillFactory _billFactory;
        private readonly IBillUserRepository _billUserRepository;
        private readonly IBillUserFactory _billUserFactory;
        private readonly ITableRepository _tableRepository;

        public BillService
        (
            IUnitOfWork unitOfWork,
            IBillRepository billRepository,
            IBillFactory billFactory,
            IBillUserRepository billUserRepository,
            IBillUserFactory billUserFactory,
            ITableRepository tableRepository
        )
        {
            _unitOfWork = unitOfWork;
            _billRepository = billRepository;
            _billFactory = billFactory;
            _billUserRepository = billUserRepository;
            _billUserFactory = billUserFactory;
            _tableRepository = tableRepository;
        }

        public async Task<bool> CheckUser(Guid billId, Guid loggedUserId)
        {
            var bill = await _billRepository.GetModelByIdWithRelationsAsync(billId);

            return bill.Users.Any(_ => _.Id == loggedUserId);
        }

        public async Task<bool> CheckRestaurant(Guid billId, Guid loggedRestaurantId)
        {
            var bill = await _billRepository.GetModelByIdWithRelationsAsync(billId);

            return bill.RestaurantId == loggedRestaurantId;
        }

        public async Task<IResult<Guid>> AddAsync(BillModelRequest model, Guid userId)
        {
            var validation = new AddBillModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var isOccupied = await _tableRepository.IsOccupied(model.TableId);
            if (isOccupied.HasValue && isOccupied.Value is true)
            {
                var obj = await _billRepository.GetActiveBillByTableAsync(model.TableId);
                return await AddUserAsync(obj.Id, userId);
            }

            var bill = _billFactory.Create(model);

            await _billRepository.AddAsync(bill);

            await _unitOfWork.SaveChangesAsync();

            var billUser = _billUserFactory.Create(bill.Id, userId);
            billUser.Activate();

            await _billUserRepository.AddAsync(billUser);

            await _unitOfWork.SaveChangesAsync();

            return bill.Id.Success();
        }

        public async Task<IResult<Guid>> AddUserAsync(Guid billId, Guid userId)
        {
            var billUser = _billUserFactory.Create(billId, userId);

            await _billUserRepository.AddAsync(billUser);

            await _unitOfWork.SaveChangesAsync();

            return billUser.BillId.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            var obj = await _billRepository.GetAsync(id);
            if (obj.Orders.Any(_ => _.Confirmed))
                return Result.Fail();

            await _billRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult<BillModelResponse?>> GetAsync(Guid id)
        {
            var response = await _billRepository.GetModelByIdWithRelationsAsync(id);
            return response.Success();
        }
        
        public async Task<IResult<BillModelResponse?>> GetActiveByTableAsync(Guid id)
        {
            var response = await _billRepository.GetActiveBillByTableAsync(id);
            return response.Success();
        }
        
        public async Task<IResult<IEnumerable<BillModelResponse>>> GetActiveByUserAsync(Guid id)
        {
            var response = await _billRepository.GetActiveBillsByUserAsync(id);
            return response.Success();
        }

        public async Task<IResult<IEnumerable<UserModelResponse>?>> GetUserPendingAsync(Guid id)
        {
            var response = await _billRepository.GetUserModelPendingAsync(id);
            return response.Success();
        }

        public async Task<IResult<IEnumerable<BillModelResponse>>> ListAsync()
        {
            var response = await _billRepository.ListModelAsync();
            return response.Success();
        }

        public async Task<IResult> UpdateAsync(BillModelRequest model)
        {
            var validation = new UpdateBillModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var bill = await _billRepository.GetAsync(model.Id);

            if (bill is null)
                return Result.Success();

            bill.Update(model.BillingStatus);

            await _billRepository.UpdateAsync(bill);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var obj = new Bill(id);
            obj.Inactivate();

            await _billRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var obj = new Bill(id);
            obj.Activate();

            await _billRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> DeclineUserAsync(Guid billId, Guid userId)
        {
            var obj = _billUserFactory.Create(billId, userId);
            obj.Inactivate();

            await _billUserRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> AcceptUserAsync(Guid billId, Guid userId)
        {
            var obj = _billUserFactory.Create(billId, userId);
            obj.Activate();

            await _billUserRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> WaiterActivateAsync(Guid id)
        {
            var obj = new Bill(id);
            obj.ActivateWaiter();

            await _billRepository.UpdateWaiterAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> WaiterInactivateAsync(Guid id)
        {
            var obj = new Bill(id);
            obj.InactivateWaiter();

            await _billRepository.UpdateWaiterAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
