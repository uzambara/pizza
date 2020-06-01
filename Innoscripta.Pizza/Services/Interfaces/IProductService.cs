using System.Collections.Generic;
using System.Threading.Tasks;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetAllAsync();
    }
}