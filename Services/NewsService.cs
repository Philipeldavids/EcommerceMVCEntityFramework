using Ecommerce.Interface;
using Ecommerce.Models;
using EcommerceData.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    /*public class NewsService : INews
    {
       private readonly ICommandHandler _handler;
        public NewsService(ICommandHandler handler)
        {
            _handler = handler;           
        }
        public async Task<List<News>> GetNews()
        {
            try
            {
                var news = await _handler.SelectAllFromDB("dbo.spGetNews");
                List<News> newsList = new List<News>();
                while (news.Read())
                {
                    News newNews = new News()
                    {
                        Id = (int)news["Id"],
                        Title = (string)news["Title"],
                        ImageUrl = (string)news["ImageUrl"],
                        Content = (string)news["Content"],
                        Date = DateTime.Now
                    };
                    newsList.Add(newNews);
                }
                return newsList;
            }
            catch (Exception)
            {

                throw;
            }
        }*//*

    }*/
}
