using Ecommerce.Enums;
using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }  
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public Category Category { get; set; }
        public Brands Brand { get; set; }
        public Ratings Rating { get; set; }
        public int NoOfPurchase { get; set; }
        public string DiscountedPrice { get; set; }
        public decimal PercentOff { get; set; } 
        public bool IsFeatured { get; set; }        
        /*public ICollection<Review> Reviews { get; set; }*/
    }
}
