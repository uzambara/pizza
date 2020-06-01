using Innoscripta.Pizza.Data.Enums;

namespace Innoscripta.Pizza.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string NameRu { get; set; }
        public string NameEng { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }
        public string DescriptionRu { get; set; }
        public string DescriptionEng { get; set; }
        public ProductType Type { get; set; }
    }
}