using FrenteDeLoja.Models;
using FrenteDeLoja.Repositories.Generico;
using System.Threading.Tasks;

namespace FrenteDeLoja.Repositories.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGeneric<Usuario>
    {
        Task<Usuario> RetornaUsuarioPorLoginESenha(string login, string senha);

    }
}
