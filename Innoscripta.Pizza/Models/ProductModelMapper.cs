using AutoMapper;
using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Models
{
    public class ProductModelMapper: Profile
    {
        public ProductModelMapper()
        {
            CreateMap<ProductEntity, ProductModel>();
        }
    }
}