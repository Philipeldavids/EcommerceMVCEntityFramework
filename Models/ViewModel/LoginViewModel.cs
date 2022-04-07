﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }  
        [Required]
        public string Password { get; set; }

    }
}
