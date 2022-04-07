using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IReadFromJson
    {
        Task<List<T>> ReadJson<T>(string jsonFile);
    }
}
