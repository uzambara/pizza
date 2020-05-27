using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Order;

namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface IOrderService
    {
        public Task<MakeOrderResponse> CreateAsync(MakeOrderRequest request);
    }
}