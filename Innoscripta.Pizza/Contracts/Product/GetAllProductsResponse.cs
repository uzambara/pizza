using System.Collections;
using System.Collections.Generic;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Contracts.Product
{
    public class GetAllProductsResponse: BaseResponse
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}