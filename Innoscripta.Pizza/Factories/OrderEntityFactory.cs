using System;
using Innoscripta.Pizza.Contracts.Order;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Factories
{
    public class OrderEntityFactory
    {
        public OrderEntity Create(string address, UserEntity user, decimal price, string comment = null)
        {
            return new OrderEntity()
            {
                Date = DateTime.Now,
                TotalPrice = price,
                Address = address,
                User = user,
                Comment = comment
            };
        }
    }
}