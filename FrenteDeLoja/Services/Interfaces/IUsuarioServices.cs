using FrenteDeLoja.Models;
using System.Threading.Tasks;

namespace FrenteDeLoja.Services.Interfaces
{
    public interface IUsuarioServices
    {
        Task<Usuario> ObterUsuario(string usuario, string senha);
    }
}
