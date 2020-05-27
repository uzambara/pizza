using System.Threading.Tasks;
using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Factories
{
    public class OrderItemFactory
    {
        public OrderItemEntity Create(int productId, decimal price, int count, OrderEntity order)
        {
            return new OrderItemEntity()
            {
                ProductId = productId,
                Count = count,
                Price = price,
                Order = order
            };
        }
    }
}