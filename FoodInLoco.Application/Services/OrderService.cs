using DotNetCore.Results;
using DotNetCore.Validation;
using FoodInLoco.Application.Data;
using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Factories;
using FoodInLoco.Application.Factories.Interfaces;
using FoodInLoco.Application.Repositories.Interfaces;
using FoodInLoco.Application.Services.Interfaces;

namespace FoodInLoco.Application.Services
{
    public sealed class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderFactory _orderFactory;

        public OrderService
        (
            IUnitOfWork unitOfWork,
            IOrderRepository orderRepository,
            IOrderFactory orderFactory
        )
        {
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
            _orderFactory = orderFactory;
        }

        public async Task<IResult<Guid>> AddAsync(OrderModelRequest model)
        {
            var validation = new AddOrderModelValidator().Validation(model);

            if (validation.Failed)
                return validation.Fail<Guid>();

            var order = _orderFactory.Create(model);

            await _orderRepository.AddAsync(order);

            await _unitOfWork.SaveChangesAsync();

            return order.Id.Success();
        }

        public async Task<IResult> DeleteAsync(Guid id)
        {
            await _orderRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult<OrderModelResponse?>> GetAsync(Guid id)
        {
            var response = await _orderRepository.GetModelByIdWithRelationsAsync(id);
            return response.Success();
        }

        public async Task<IResult<IEnumerable<OrderModelResponse>>> ListAsync()
        {
            var response = await _orderRepository.ListModelAsync();
            return response.Success();
        }

        public async Task<IResult> UpdateAsync(OrderModelRequest model)
        {
            var validation = new UpdateOrderModelValidator().Validation(model);

            if (validation.Failed)
                return validation;

            var order = await _orderRepository.GetAsync(model.Id);

            if (order is null)
                return Result.Success();

            order.Update(model.Quantity, model.Message);

            await _orderRepository.UpdateAsync(order);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> InactivateAsync(Guid id)
        {
            var obj = new Order(id);
            obj.Inactivate();

            await _orderRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<IResult> ActivateAsync(Guid id)
        {
            var obj = new Order(id);
            obj.Activate();

            await _orderRepository.UpdateStatusAsync(obj);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
