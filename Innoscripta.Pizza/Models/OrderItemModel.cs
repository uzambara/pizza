namespace Innoscripta.Pizza.Models
{
    public class OrderItemModel
    {
        public decimal Price { get; set; }
        public string ProductNameRu { get; set; }
        public string ProductNameEng { get; set; }
        public string ProductImg { get; set; }
        public int Count { get; set; }
    }
}