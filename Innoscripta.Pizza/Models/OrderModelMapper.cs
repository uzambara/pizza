using AutoMapper;
using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Models
{
    public class OrderModelMapper: Profile
    {
        public OrderModelMapper()
        {
            CreateMap<OrderEntity, OrderModel>();
        }
    }
}