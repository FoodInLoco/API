using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Repositories;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class BillService : IBillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBillRepository _billRepository;
        private readonly IBillFactory _billFactory;

        public BillService
        (
            IUnitOfWork unitOfWork,
            IBillRepository billRepository,
            IBillFactory billFactory
        )
        {
            _unitOfWork = unitOfWork;
            _billRepository = billRepository;
            _billFactory = billFactory;
        }

        public async Task<IResult<Guid>> AddAsync(BillModelRequest model)
        {
            var validation = new AddBillModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var bill = _billFactory.Create(model);

            await _billRepository.AddAsync(bill);

            await _unitOfWork.SaveChangesAsync();

            return bill.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _billRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<BillModelResponse?> GetAsync(Guid id)
        {
            return _billRepository.GetModelByIdWithRelationsAsync(id);
        }
        
        public Task<BillModelResponse?> GetActiveByTableAsync(Guid id)
        {
            return _billRepository.GetActiveBillByTableAsync(id);
        }
        
        public Task<IEnumerable<BillModelResponse>> GetActiveByUserAsync(Guid id)
        {
            return _billRepository.GetActiveBillsByUserAsync(id);
        }

        public async Task<IEnumerable<BillModelResponse>> ListAsync()
        {
            return await _billRepository.ListModelAsync();
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
    }
}
