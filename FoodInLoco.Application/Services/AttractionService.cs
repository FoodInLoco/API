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
    public sealed class AttractionService : IAttractionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAttractionRepository _attractionRepository;
        private readonly IAttractionFactory _attractionFactory;

        public AttractionService
        (
            IUnitOfWork unitOfWork,
            IAttractionRepository attractionRepository,
            IAttractionFactory attractionFactory
        )
        {
            _unitOfWork = unitOfWork;
            _attractionRepository = attractionRepository;
            _attractionFactory = attractionFactory;
        }

        public async Task<IResult<Guid>> AddAsync(AttractionModel model)
        {
            var validation = new AddAttractionModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var restaurant = _attractionFactory.Create(model);

            await _attractionRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _attractionRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<AttractionModel> GetAsync(Guid id)
        {
            return _attractionRepository.GetModelByIdAsync(id);
        }
        
        public async Task<IEnumerable<AttractionModel>> ListAsync()
        {
            return await _attractionRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(AttractionModel model)
        {
            var validation = new UpdateAttractionModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var attraction = await _attractionRepository.GetAsync(model.Id);

            if (attraction is null)
                return Result.Success();

            attraction.Update(model.Name, model.Description, model.Photo, model.Date, model.Time, model.CoverTax);

            await _attractionRepository.UpdateAsync(attraction);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var obj = new Attraction(id);
            obj.Inactivate();

            await _attractionRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var obj = new Attraction(id);
            obj.Activate();

            await _attractionRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
