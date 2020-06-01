using System.Collections.Generic;
using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Order;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderModel> CreateAsync(MakeOrderRequest request);
    }
}