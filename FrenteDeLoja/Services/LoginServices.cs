using AutoMapper;
using FrenteDeLoja.Models;
using FrenteDeLoja.Services.Interfaces;
using FrenteDeLoja.View;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenteDeLoja.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioServices _usuarioService;


        public LoginServices(IMapper mapper, IUsuarioServices usuarioService)
        {
            _mapper = mapper;
            _usuarioService = usuarioService;
        }

        public async Task<Usuario> Login(string login, string senha)
        {
            Usuario usuario = new Usuario();

            TelaPrincipal telaPrincipal = new TelaPrincipal();

            try
            {
                usuario = await _usuarioService.ObterUsuario(login, senha);

            }

            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No Banco");
            }

            return usuario;
        }
    }
}
