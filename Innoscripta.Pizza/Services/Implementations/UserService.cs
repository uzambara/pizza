using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Innoscripta.Pizza.Contracts;
using Innoscripta.Pizza.Contracts.Account;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Enums;
using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Factories;
using Innoscripta.Pizza.Models;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Innoscripta.Pizza.Services.Implementations
{
    public class UserService: IUserService
    {
        // Repositories
        private readonly BaseRepository<UserEntity> _userRepository;
        private readonly BaseRepository<OrderEntity> _orderRepository;
        private readonly BaseRepository<UserStatisticEntity> _userStatisticRepository;

        // Factories
        private readonly UserEntityFactory _userEntityFactory;
        private readonly UserStatisticFactory _userStatisticFactory;

        // Mapper
        private readonly IMapper _mapper;

        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(
            BaseRepository<UserEntity> userRepository,
            BaseRepository<OrderEntity> orderRepository,
            BaseRepository<UserStatisticEntity> userStatisticRepository,
            UserStatisticFactory userStatisticFactory,
            UserEntityFactory userEntityFactory,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _userEntityFactory = userEntityFactory;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userStatisticFactory = userStatisticFactory;
            _userStatisticRepository = userStatisticRepository;
            _orderRepository = orderRepository;
        }

        public async Task<AccountRegistrationResponse> RegisterUserAsync(AccountRegistrationRequest request)
        {
            var existsUser = await GetUserByPhoneAsync(request.Phone);
            if (existsUser?.CreateUserPlace == CreateUserPlace.FromRegistration)
            {
                return new AccountRegistrationResponse()
                {
                    Code = ResponseCode.UserWithTheSamePhoneExists
                };
            }

            var user = _userEntityFactory.Create(
                request.Name,
                request.LastName,
                request.Phone,
                request.Password,
                CreateUserPlace.FromRegistration);

            _userRepository.Add(user);
            await _userRepository.SaveChangesAsync();
            return new AccountRegistrationResponse()
            {
                User = _mapper.Map<UserModel>(user)
            };
        }

        public Task<UserEntity> GetUserByPhoneAsync(string phone)
        {
            return _userRepository.GetOneWhereAsync(u => u.Phone == phone);
        }

        public async Task<UserEntity> GetCurrentUserAsync()
        {
            var phone = _httpContextAccessor.HttpContext.User.Identity.Name;
            return await GetUserByPhoneAsync(phone);
        }

        public async Task<IEnumerable<OrderModel>> GetHistoryAsync(int userId)
        {
            var orders = await _orderRepository
                .GetAllWhere(o => o.UserId == userId && o.Deleted == null)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .ToListAsync();

            return _mapper.Map<IEnumerable<OrderModel>>(orders);
        }

        public async Task<UserStatisticModel> GetStatisticAsync(int userId)
        {
            var result = await _userStatisticRepository.GetOneAsync(userId);
            if (result == null)
            {
                result = _userStatisticFactory.Create(userId);
                _userStatisticRepository.Add(result);
                await _userStatisticRepository.SaveChangesAsync();
            }

            return _mapper.Map<UserStatisticModel>(result);
        }
    }
}