using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Innoscripta.Pizza.Contracts.Order;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Enums;
using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Factories;
using Innoscripta.Pizza.Models;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Innoscripta.Pizza.Services.Implementations
{
    public class OrderService: IOrderService
    {
        // Repositories
        private readonly BaseRepository<OrderEntity> _orderRepository;
        private readonly BaseRepository<UserEntity> _userRepository;
        private readonly BaseRepository<OrderItemEntity> _orderItemRepository;
        private readonly BaseRepository<UserStatisticEntity> _userStatisticRepository;

        // Services
        private readonly IUserService _userService;

        // Factories
        private readonly UserEntityFactory _userEntityFactory;
        private readonly OrderEntityFactory _orderEntityFactory;
        private readonly OrderItemFactory _orderItemFactory;

        // Mapper
        private readonly IMapper _mapper;

        private decimal _bonusPart = 0.05m;

        private readonly ILogger<OrderService> _logger;

        public OrderService(
            BaseRepository<OrderEntity> orderRepository,
            BaseRepository<UserEntity> userRepository,
            BaseRepository<OrderItemEntity> orderItemRepository,
            BaseRepository<UserStatisticEntity> userStatisticRepository,
            UserEntityFactory userEntityFactory,
            OrderEntityFactory orderEntityFactory,
            OrderItemFactory orderItemFactory,
            IUserService userService,
            IMapper mapper,
            ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _userEntityFactory = userEntityFactory;
            _orderEntityFactory = orderEntityFactory;
            _orderItemFactory = orderItemFactory;
            _userService = userService;
            _mapper = mapper;
            _logger = logger;
            _userStatisticRepository = userStatisticRepository;
            _orderItemRepository = orderItemRepository;
        }

        public async Task<OrderModel> CreateAsync(MakeOrderRequest request)
        {
            try
            {
                // Get or create user
                var user = await _userService.GetUserByPhoneAsync(request.Phone);
                if (user == null)
                {
                    user = _userEntityFactory.Create(
                        request.Name,
                        request.LastName,
                        request.Phone,
                        null,
                        CreateUserPlace.FromOrder);

                    _userRepository.Add(user);
                }

                // Create order
                var order = _orderEntityFactory.Create(
                    request.Address,
                    user,
                    request.CalculateTotalPrice(),
                    request.Comment);
                _orderRepository.Add(order);

                // Create order items
                foreach (var requestOrderPosition in request.OrderPositions)
                {
                    var orderItem = _orderItemFactory.Create(
                        requestOrderPosition.ProductId,
                        requestOrderPosition.Price,
                        requestOrderPosition.Count,
                        order);
                    _orderItemRepository.Add(orderItem);
                }

                // Change user statistic
                var statistic = await _userStatisticRepository.GetOneAsync(user.Id);
                if (statistic == null)
                {
                    statistic = new UserStatisticEntity {User = user};
                    statistic.OrdersCount++;
                    statistic.TotalOrdersPrice += order.TotalPrice;
                    statistic.Bonus += order.TotalPrice * _bonusPart;
                    _userStatisticRepository.Add(statistic);
                }
                else
                {
                    statistic.OrdersCount++;
                    statistic.TotalOrdersPrice += order.TotalPrice;
                    statistic.Bonus += order.TotalPrice * _bonusPart;
                    _userStatisticRepository.Update(statistic);
                }

                await _orderRepository.SaveChangesAsync();
                return _mapper.Map<OrderModel>(order);

            }
            catch(Exception ex)
            {
                _logger.LogError(ex.ToString());
                return null;
            }
        }
    }
}