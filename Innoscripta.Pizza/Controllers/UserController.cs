using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Order;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Innoscripta.Pizza.Controllers
{
    [Authorize]
    public class UserController: BaseController
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public UserController(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        [HttpGet]
        [Route(Routing.ApiRoutes.User.OrderHistory)]
        public async Task<GetOrderHistoryResponse> GetOrderHistory()
        {
            var currentUser = await _userService.GetCurrentUserAsync();
            var orders = await _userService.GetHistoryAsync(currentUser.Id);
            return new GetOrderHistoryResponse()
            {
                OrderHistory = orders
            };
        }

        [HttpGet]
        [Route(Routing.ApiRoutes.User.Statistic)]
        public async Task<GetUserStatisticResponse> GetStatistic()
        {
            var currentUser = await _userService.GetCurrentUserAsync();
            var statistic = await _userService.GetStatisticAsync(currentUser.Id);
            return new GetUserStatisticResponse()
            {
                Statistic = statistic
            };
        }
    }
}