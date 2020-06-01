using System.Collections.Generic;
using System.Linq;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Contracts.Order
{
    public class MakeOrderRequest
    {
        public IEnumerable<OrderPosition> OrderPositions { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }

        public decimal CalculateTotalPrice()
        {
            return OrderPositions.Sum(item => item.Price * item.Count);
        }
    }
}