using System.Collections.Generic;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Contracts.Order
{
    public class GetOrderHistoryResponse: BaseResponse
    {
        public IEnumerable<OrderModel> OrderHistory { get; set; }
    }
}