using Ecommerce.Interface;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
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
        public async Task<IActionResult> ProductList(/*int page=1*/)
        {
            var products = await _product.GetProduct();
            /*var productView = new ProductViewModel()
            {
                Products = products,
                ProductPerPage = 16,
                Currentpage = page
            };*/
            return View(products);
        }
       /* public async Task<IActionResult> ProductListFeatured()
        {
            var products = await _product.GetProduct();
               
            return View(products);
        }*/

    }
}
