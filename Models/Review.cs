

using Ecommerce.Enums;

namespace Ecommerce.Models
{
    public class Review
    {
        
        public int Id { get; set; }
        public string UserId { get; set; }
        public Ratings Rating { get; set; }
        public string Description { get; set; }
    }
}
