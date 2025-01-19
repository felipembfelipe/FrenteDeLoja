using FrenteDeLoja.Models;
using FrenteDeLoja.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenteDeLoja.View.Login
{
    public partial class frmLogin : Form
    {
        private readonly ILoginServices _loginServices;

        // O construtor agora recebe a dependência ILoginServices, que será injetada pelo Unity
        public frmLogin(ILoginServices loginServices)
        {
            _loginServices = loginServices;
            InitializeComponent();
        }

        // Evento do clique no botão de login
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Chama o método Login do serviço injetado
            Usuario usuario = await _loginServices.Login(login, senha);

            if (usuario == null)
            {
                MessageBox.Show("Login falhou, usuário não encontrado.");
                return;
            }

            // Aqui você pode adicionar o código para continuar com a aplicação, 
            // como redirecionar o usuário para outra tela, etc.
            MessageBox.Show($"Bem-vindo!");
        }
    }
}
