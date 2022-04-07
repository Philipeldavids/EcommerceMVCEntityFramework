using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IUsers
    {
        Task<List<User>> GetUsers();
        Task<bool> AddUser(User user);
    }
}
