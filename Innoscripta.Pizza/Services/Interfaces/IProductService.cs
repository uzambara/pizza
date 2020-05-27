using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Product;

namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface IProductService
    {
        public Task<GetAllProductsResponse> GetAllAsync();
    }
}