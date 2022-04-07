using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IWriteToJson
    {
        Task<bool> WriteJson<T>(T model, string jsonFile);
    }
}
