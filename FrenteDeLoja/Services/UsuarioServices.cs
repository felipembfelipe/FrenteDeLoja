using FrenteDeLoja.Models;
using FrenteDeLoja.Repositories.Interfaces;
using FrenteDeLoja.Services.Interfaces;
using System.Threading.Tasks;

namespace FrenteDeLoja.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServices(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<Usuario> ObterUsuario(string usuario, string senha)
        {
            var user = await _usuarioRepositorio.RetornaUsuarioPorLoginESenha(usuario, senha);
            return user;
        }
    }
}
