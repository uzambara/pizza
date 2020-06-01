namespace Innoscripta.Pizza.Models
{
    public class OrderPosition
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}