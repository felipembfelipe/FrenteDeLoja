using AutoMapper;
using FrenteDeLoja.DTO;
using FrenteDeLoja.Models;
using FrenteDeLoja.Services.Interfaces;
using FrenteDeLoja.View;
using FrenteDeLoja.View.Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

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
            string usu, pwd;
            Usuario usuario = new Usuario();

            TelaPrincipal telaPrincipal = new TelaPrincipal();

            try
            {
                usuario = await _usuarioService.ObterUsuario(login, senha);


                //_sql = "SELECT COUNT(id_user)FROM login WHERE login_user = @login_usuario AND senha_user = @senha_usuario";
                //SqlCommand cmd2 = new SqlCommand("select TipoUsuario from login where login_user ='" + textBox1.Text + "'and senha_user = '" + textBox2.Text + "';", conn);
                //SqlCommand cmd = new SqlCommand(_sql, conn);

                //cmd.Parameters.Add("@login_usuario ", SqlDbType.VarChar).Value = usu;
                //cmd.Parameters.Add("@senha_usuario ", SqlDbType.VarChar).Value = pwd;

                //conn.Open();
                //int v = (int)cmd.ExecuteScalar();
                //String adm = (String)Convert.ToString(cmd2.ExecuteScalar());

                //if (adm == "Administrador" || textBox1.Text == "Javassaladores" && textBox2.Text == "102030")
                //{
                //    this.Visible = false;
                //    MessageBox.Show("Logado com Sucesso");
                //    ap.Visible = true;
                //    f.Close();


                //}
                //else
                //    if (v > 0)
                //{
                //    this.Visible = false;
                //    MessageBox.Show("Logado com Sucesso!");
                //    p.Visible = true;
                //    f.Close();


                //}
                //else
                //        if (textBox1.Text == "" || textBox2.Text == "")
                //{
                //    MessageBox.Show("Preencha os campos vazios!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                //else
                //{
                //    MessageBox.Show("Erro ao Logar");
                //    logado = false;
                //}
            }

            catch (SqlException erro)
            {
                //MessageBox.Show(erro + "No Banco");
            }

            return usuario;
        }
    }
}
