using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts;
using Innoscripta.Pizza.Contracts.Order;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Innoscripta.Pizza.Controllers
{
    public class OrderController: BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController(
            IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        [Route(Routing.ApiRoutes.Order.Create)]
        public async Task<MakeOrderResponse> Create(MakeOrderRequest request)
        {
            var order = await _orderService.CreateAsync(request);
            if (order == null)
            {
                return new MakeOrderResponse()
                {
                    Code = ResponseCode.InnerError
                };
            }
            return new MakeOrderResponse();
        }
    }
}