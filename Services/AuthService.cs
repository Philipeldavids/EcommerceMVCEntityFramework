using Ecommerce.Interface;
using Ecommerce.Models.ViewModel;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class AuthService : IAuthenticate
    {
        private readonly IUsers _user;

        public AuthService(IUsers user)
        {
            _user = user;
        }

        public async Task<bool> LoginAsync(LoginViewModel model)
        {
            var userlist = await _user.GetUsers();
            foreach(var item in userlist)
            {
                if(userlist== null)
                {
                    return false;
                }

                if(item.Email == model.Email && item.Password == model.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
