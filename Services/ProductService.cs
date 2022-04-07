using Ecommerce.Interface;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProductService : IProduct
    {
        private readonly IReadFromJson _dbContext;
        private readonly IWriteToJson _writeToJson;
        private readonly string userFile = "Products.json";
        public ProductService(IReadFromJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Product>> GetProduct()
        {
            try
            {
                return await _dbContext.ReadJson<Product>(userFile);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> AddProduct(Product product)
        {
            try
            {
                return await _writeToJson.WriteJson(product, userFile);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
