namespace Innoscripta.Pizza.Models
{
    public class OrderItemModel
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}