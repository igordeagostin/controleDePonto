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
    public partial class TelaCadastroUsuarios : Form
    {
        int id;
        public TelaCadastroUsuarios()
        {
            InitializeComponent();
            textBoxSenha.PasswordChar = '*';
        }
        public TelaCadastroUsuarios(Usuario usuario)
        {
            InitializeComponent();
            id = usuario.Id;
            textBoxNome.Text = usuario.Nome;
            textBoxLogin.Text = usuario.Login;
            textBoxSenha.Text = usuario.Senha;

            textBoxSenha.PasswordChar = '*';
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            Usuario usuario;

            if (usuarioController.BuscaPorId(id) != null)
            {
                usuario = usuarioController.BuscaPorId(id);
            }
            else
            {
                usuario = new Usuario();
            }

            usuario.Nome = textBoxNome.Text;
            usuario.Login = textBoxLogin.Text;
            usuario.Senha = textBoxSenha.Text;

            usuarioController.SaveOrUpdate(usuario);
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
