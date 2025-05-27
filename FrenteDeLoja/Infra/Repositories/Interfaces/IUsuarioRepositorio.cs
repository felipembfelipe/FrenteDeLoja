using FrenteDeLoja.Infra.Repositories.Generico;
using FrenteDeLoja.Models;
using System.Threading.Tasks;

namespace FrenteDeLoja.Infra.Repositories.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGeneric<Usuario>
    {
        Task<Usuario> RetornaUsuarioPorLoginESenha(string login, string senha);

        Task<Usuario> RetornaUsuarioPorLogin(string login);

        Task<Usuario> RetornaUsuarioPorEmailELogin(string usuario, string email);

    }
}
