using Ecommerce.Interface;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUsers _user;
        public UserController(IUsers user)
        {
            _user = user;
        }
       
        public async Task<IActionResult> Register(UserViewModel viewmodel)
        {
            var newUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = viewmodel.FirstName,
                LastName = viewmodel.LastName,
                Email = viewmodel.Email,
                Password = viewmodel.Password,
                PhoneNumber = viewmodel.PhoneNumber,
                Address = viewmodel.Address,
                Gender = viewmodel.Gender = true ? "Male": "Female",
                DateofBirth = viewmodel.DateofBirth,
            };
            var added = await _user.AddUser(newUser);
            if (added)
            {
                return RedirectToAction("Login","Authentication");
            }

            return View();  
        }        
    }
}
