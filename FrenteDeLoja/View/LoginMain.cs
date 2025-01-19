using FrenteDeLoja.Models;
using FrenteDeLoja.Services;
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
using Unity;

namespace FrenteDeLoja.View.Login
{
    public partial class frmLogin : Form
    {
        private readonly ILoginServices _loginServices;

        bool logado = false;
        DateTime data_hora;

        // O construtor agora recebe a dependência ILoginServices, que será injetada pelo Unity
        public frmLogin(ILoginServices loginServices)
        {
            _loginServices = loginServices;
            InitializeComponent();
        }

        // Evento do clique no botão de login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Autenticacao();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa? ", "Mensagem do Sistema ",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkEsqueci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SenhaPergunta1 se = new SenhaPergunta1();
            //se.ShowDialog();
        }

        private void linkTrocar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SenhaNova sn = new SenhaNova();
            //sn.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lblDataAgora.Text = data_hora.ToLongDateString();
            lblHoraAgora.Text = data_hora.ToLongTimeString();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autenticacao();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }


        public async void Autenticacao()
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            frmLogin novoLogin = new frmLogin(_loginServices);

            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Chama o método Login do serviço injetado
                Usuario usuario = await _loginServices.Login(login, senha);

                // Valida autenticação
                if (usuario == null)
                {
                    MessageBox.Show("Erro ao Logar");
                    logado = false;
                }
                else
                {
                    this.Visible = false;
                    MessageBox.Show("Logado com Sucesso");
                    telaPrincipal.Visible = true;
                    novoLogin.Close();
                }
            }
        }
    }
}
