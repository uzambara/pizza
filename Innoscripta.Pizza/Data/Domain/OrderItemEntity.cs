using System;

namespace Innoscripta.Pizza.Data.Domain
{
    public class OrderItemEntity: IEntityBase
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime? Deleted { get; set; }
    }
}