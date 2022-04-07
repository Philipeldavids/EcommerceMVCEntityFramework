using Ecommerce.Interface;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class UserService : IUsers
    {
        private readonly IReadFromJson _dbContext;
        private readonly IWriteToJson _writeToJson;
        private readonly string userFile = "User.json";
        public UserService(IReadFromJson dbContext , IWriteToJson writeToJson)
        {
            _dbContext = dbContext;
            _writeToJson = writeToJson;
        }
        public async Task<List<User>> GetUsers()
        {
            try
            {
                return (List<User>)await _dbContext.ReadJson<User>(userFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> AddUser(User user)
        {
            try
            {
                return await _writeToJson.WriteJson(user, userFile);
            }
            catch (Exception)
            {

                throw;
            }
        }   
    }
}
