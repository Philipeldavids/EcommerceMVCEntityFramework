using Ecommerce.Interface;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProduct _product;
        public ProductsController(IProduct product)
        {
            _product = product;
        }
        public async Task<IActionResult> ProductList()
        {
            var products = await _product.GetProduct();
            return View(products);
        }
    }
}
