using Ecommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IProduct
    {
        Task<List<Product>> GetProduct();
    }
}
