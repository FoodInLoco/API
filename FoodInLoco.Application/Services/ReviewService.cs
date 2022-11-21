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
    public sealed class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReviewRepository _reviewRepository;
        private readonly IReviewFactory _reviewFactory;

        public ReviewService
        (
            IUnitOfWork unitOfWork,
            IReviewRepository reviewRepository,
            IReviewFactory reviewFactory
        )
        {
            _unitOfWork = unitOfWork;
            _reviewRepository = reviewRepository;
            _reviewFactory = reviewFactory;
        }

        public async Task<IResult<Guid>> AddAsync(ReviewModel model)
        {
            var validation = new AddReviewModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var restaurant = _reviewFactory.Create(model);

            await _reviewRepository.AddAsync(restaurant);

            await _unitOfWork.SaveChangesAsync();

            return restaurant.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _reviewRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<ReviewModel> GetAsync(Guid id)
        {
            return _reviewRepository.GetModelByIdAsync(id);
        }

        public async Task<IEnumerable<ReviewModel>> ListAsync()
        {
            return await _reviewRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(ReviewModel model)
        {
            var validation = new UpdateReviewModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var attraction = await _reviewRepository.GetAsync(model.Id);

            if (attraction is null)
                return Result.Success();

            attraction.Update(model.Name, model.Description, model.Rate);

            await _reviewRepository.UpdateAsync(attraction);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var obj = new Review(id);
            obj.Inactivate();

            await _reviewRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var obj = new Review(id);
            obj.Activate();

            await _reviewRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
