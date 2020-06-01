using System.Collections.Generic;

namespace Innoscripta.Pizza.Models
{
    public class OrderModel
    {
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
        public IEnumerable<OrderItemModel> OrderItems { get; set; }
    }
}