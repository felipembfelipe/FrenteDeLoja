using FrenteDeLoja.Models;
using System.Threading.Tasks;

namespace FrenteDeLoja.Services.Interfaces
{
    public interface ILoginServices
    {
        Task<Usuario> Login(string login, string senha);
    }
}
