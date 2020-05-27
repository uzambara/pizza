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
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route(ApiRoutes.Product.GetAll)]
        public async Task<GetAllProductsResponse> GetAll()
        {
            return await _productService.GetAllAsync();
        }
    }
}