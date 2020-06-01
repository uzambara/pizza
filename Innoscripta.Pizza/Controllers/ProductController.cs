using System;
using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Product;
using Innoscripta.Pizza.Routing;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Innoscripta.Pizza.Controllers
{
    public class ProductController: BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route(ApiRoutes.Product.GetAll)]
        public async Task<GetAllProductsResponse> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return new GetAllProductsResponse()
            {
                Products = products
            };
        }
    }
}