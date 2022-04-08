using Ecommerce.Interface;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class NewsService : INews
    {
        private readonly IReadFromJson _dbContext;
        private readonly string userFile = "news.json";
        public NewsService(IReadFromJson dbContext)
        {
            _dbContext = dbContext;           
        }
        public async Task<List<News>> GetNews()
        {
            try
            {
                return (List<News>)await _dbContext.ReadJson<News>(userFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
