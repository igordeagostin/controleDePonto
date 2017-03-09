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
    public partial class TelaUsuarios : Form
    {
        int id;
        public TelaUsuarios()
        {
            InitializeComponent();
            configuraDataGridView();
        }

        public void configuraDataGridView()
        {
            UsuarioController usuarioController = new UsuarioController();

            var lista = usuarioController.Lista().Select(usuario => new
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Login = usuario.Login,
                Senha = usuario.Senha
            }).ToList();
            dataGridViewUsuarios.DataSource = lista;

            // Renomeia as colunas do DataGridView

            dataGridViewUsuarios.Columns[0].HeaderText = "ID";
            dataGridViewUsuarios.Columns[0].Name = "ID";
            dataGridViewUsuarios.Columns[1].HeaderText = "NOME";
            dataGridViewUsuarios.Columns[2].HeaderText = "LOGIN";
            dataGridViewUsuarios.Columns[3].HeaderText = "SENHA";

            
            dataGridViewUsuarios.Columns[3].Visible = false;
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastroUsuarios form = new TelaCadastroUsuarios();
            form.ShowDialog();
            configuraDataGridView();
        }
        public bool verificaId()
        {
            if (id > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Você deve selecionar um registro para continuar!");
                return false;
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (verificaId())
            {
                UsuarioController usuarioController = new UsuarioController();
                Usuario usuario = usuarioController.BuscaPorId(id);
                var form = new TelaCadastroUsuarios(usuario);
                form.ShowDialog();
                configuraDataGridView();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (verificaId())
            {
                UsuarioController usuarioController = new UsuarioController();
                Usuario usuario = usuarioController.BuscaPorId(id);
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Ponto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    usuarioController.Remove(usuario);
                }

                configuraDataGridView();
            }
        }

        private void dataGridViewFuncoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewUsuarios["ID", e.RowIndex].Value);
        }

        private void dataGridViewFuncoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                id = Convert.ToInt32(dataGridViewUsuarios["ID", e.RowIndex].Value);
                UsuarioController usuarioController = new UsuarioController();
                Usuario usuario = usuarioController.BuscaPorId(id);
                var form = new TelaCadastroUsuarios(usuario);
                form.ShowDialog();
                configuraDataGridView();
        }
    }
}
