using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Order;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Factories;
using Innoscripta.Pizza.Services.Interfaces;

namespace Innoscripta.Pizza.Services.Implementations
{
    public class OrderService: IOrderService
    {
        private readonly BaseRepository<OrderEntity> _orderRepository;
        private readonly BaseRepository<UserEntity> _userRepository;
        private readonly BaseRepository<OrderItemEntity> _orderItemRepository;

        private readonly UserEntityFactory _userEntityFactory;
        private readonly OrderEntityFactory _orderEntityFactory;
        private readonly OrderItemFactory _orderItemFactory;

        public OrderService(
            BaseRepository<OrderEntity> orderRepository,
            BaseRepository<UserEntity> userRepository,
            BaseRepository<OrderItemEntity> orderItemRepository,
            UserEntityFactory userEntityFactory,
            OrderEntityFactory orderEntityFactory,
            OrderItemFactory orderItemFactory)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _userEntityFactory = userEntityFactory;
            _orderEntityFactory = orderEntityFactory;
            _orderItemFactory = orderItemFactory;
            _orderItemRepository = orderItemRepository;
        }

        public async Task<MakeOrderResponse> CreateAsync(MakeOrderRequest request)
        {
            var result = new MakeOrderResponse();

            var user = _userEntityFactory.Create(
                request.Name,
                request.LastName,
                request.Phone,
                null);
            _userRepository.Add(user);

            var order = _orderEntityFactory.Create(
                request.Address,
                user,
                request.CalculateTotalPrice(),
                request.Comment);
            _orderRepository.Add(order);

            foreach (var requestOrderPosition in request.OrderPositions)
            {
                var orderItem = _orderItemFactory.Create(
                    requestOrderPosition.ProductId,
                    requestOrderPosition.Price,
                    requestOrderPosition.Count,
                    order);
                _orderItemRepository.Add(orderItem);
            }

            await _orderRepository.SaveChangesAsync();
            return result;
        }
    }
}