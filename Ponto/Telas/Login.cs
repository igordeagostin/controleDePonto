using Ponto.Controllers;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto.Telas
{
    public partial class Login : Form
    {
        public Login(Usuario usuario)
        {
            InitializeComponent();
            textBoxSenha.PasswordChar = '*';
            KeyPreview = true;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();

            if(usuarioController.Login(textBoxLogin.Text, textBoxSenha.Text)){
                TelaPrincipal formPrincipal = new TelaPrincipal();
                formPrincipal.Show();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEntrar_Click(sender, e);
            }
        }
    }
}
