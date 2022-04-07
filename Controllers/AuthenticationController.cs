using Ecommerce.Interface;
using Ecommerce.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticate _authenticate;
        public AuthenticationController(IAuthenticate authenticate)
        {
            _authenticate = authenticate;
        }

        
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            
            if (ModelState.IsValid)
            {
                if(await _authenticate.LoginAsync(viewModel))
                {
                    return RedirectToAction("Index","Home");                    
                }                
            }
            return View(viewModel);
        }
        public IActionResult LoadSignUp()
        {
            return View();
        }
        /*[HttpPost("Login")]
        public IActionResult Login()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }*/
    }
}
