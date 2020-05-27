using Innoscripta.Pizza.Data.Enums;

namespace Innoscripta.Pizza.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
    }
}