using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Models.ViewModel
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public int ProductPerPage { get; set; }
        public int Currentpage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Products.Count() / (double)ProductPerPage));
        }

        public IEnumerable<Product> PaginatedPage()
        {
            int start = (Currentpage-1) * ProductPerPage;
            return Products.OrderBy(x => x.Id).Skip(start).Take(ProductPerPage);
        }
    }
}
