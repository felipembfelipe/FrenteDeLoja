using FrenteDeLoja.Infra.Contexto;
using FrenteDeLoja.Models;
using FrenteDeLoja.Repositories.Generico;
using FrenteDeLoja.Repositories.Interfaces;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FrenteDeLoja.Repositories
{
    public class UsuarioRepositorio : RepositorioGeneric<Usuario>, IUsuarioRepositorio
    {
        private readonly MDContext _context;

        public UsuarioRepositorio(MDContext context) : base(context) { _context = context; }

        public async Task<Usuario> RetornaUsuarioPorLoginESenha(string login, string senha) => await _context.Usuarios.FirstOrDefaultAsync(x => x.LoginUsuario.ToUpper() == login && x.SenhaUsuario.ToUpper() == senha);
    }
}
