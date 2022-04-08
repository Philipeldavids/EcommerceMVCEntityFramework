using System.Collections.Generic;

namespace Ecommerce.Models.ViewModel
{
    public class UserProductViewModel
    {
        public List<UserViewModel> UserView { get; set; }
        public List<ProductViewModel> ProductView { get; set; }

        public List<LoginViewModel> LoginView { get; set; }

    }
}
