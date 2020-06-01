using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Innoscripta.Pizza.Data.Enums;

namespace Innoscripta.Pizza.Data.Domain
{
    [Table("Products")]
    public class ProductEntity: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(64)]
        public string NameRu { get; set; }
        [MaxLength(64)]
        public string NameEng { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }
        [MaxLength(1024)]
        public string DescriptionRu { get; set; }
        [MaxLength(1024)]
        public string DescriptionEng { get; set; }
        public ProductType Type { get; set; }
        public DateTime? Deleted { get; set; }
    }
}