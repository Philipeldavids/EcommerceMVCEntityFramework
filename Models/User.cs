using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string FullName
        {
            get => FirstName + " " + LastName;
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set;}
        public string PhoneNumber { get; set; }
        public string Address { get; set; } 
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; }
        public bool IsDeprecated { get; set; }
    }
}
