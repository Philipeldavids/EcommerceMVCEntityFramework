using Ecommerce.Interface;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Ecommerce.Helper
{
    public class WriteToJson : IWriteToJson
    {
        private readonly string dbase = @"C:\Users\hp\source\repos\MVC\Ecommerce\Database\";
        public async Task<bool> WriteJson<T>(T model, string jsonFile)
        {

            try
            {
                string json = JsonConvert.SerializeObject(model) + Environment.NewLine;
                await File.AppendAllTextAsync(dbase + jsonFile, json);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
