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
    public sealed class TableService : ITableService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITableRepository _tableRepository;
        private readonly ITableFactory _tableFactory;

        public TableService
        (
            IUnitOfWork unitOfWork,
            ITableRepository tableRepository,
            ITableFactory tableFactory
        )
        {
            _unitOfWork = unitOfWork;
            _tableRepository = tableRepository;
            _tableFactory = tableFactory;
        }

        public async Task<IResult<Guid>> AddAsync(TableModelRequest model)
        {
            var validation = new AddTableModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var table = _tableFactory.Create(model);

            await _tableRepository.AddAsync(table);

            await _unitOfWork.SaveChangesAsync();

            return table.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _tableRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult<TableModelResponse?>> GetAsync(Guid id)
        {
            var response = await _tableRepository.GetModelByIdWithRelationsAsync(id);
            return response.Success();
        }

        public async Task<IResult<IEnumerable<TableModelResponse>>> GetFromRestaurantAsync(Guid id)
        {
            var response = await _tableRepository.GetTablesFromRestaurantAsync(id);
            return response.Success();
        }
        
        public async Task<IResult<IEnumerable<TableModelResponse>>> ListAsync()
        {
            var response = await _tableRepository.ListModelAsync();
            return response.Success();
        }

        public async Task<IResult> UpdateAsync(TableModelRequest model)
        {
            var validation = new UpdateTableModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var table = await _tableRepository.GetAsync(model.Id);

            if (table is null)
                return Result.Success();

            table.Update(model.Number);

            await _tableRepository.UpdateAsync(table);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var obj = new Table(id);
            obj.Inactivate();

            await _tableRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var obj = new Table(id);
            obj.Activate();

            await _tableRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
