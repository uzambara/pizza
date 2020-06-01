using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Innoscripta.Pizza.Contracts.Product;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Models;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Innoscripta.Pizza.Services.Implementations
{
    public class ProductService: IProductService
    {
        // Repositories
        private readonly BaseRepository<ProductEntity> _productRepository;

        // Mapper
        private readonly IMapper _mapper;

        public ProductService(BaseRepository<ProductEntity> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            var products = await _productRepository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }
    }
}