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
    public partial class TelaFuncoes : Form
    {
        int id;
        public TelaFuncoes()
        {
            InitializeComponent();
            configuraDataGridView();
        }

        public void configuraDataGridView()
        {
            FuncaoController funcaoController = new FuncaoController();

            var lista = funcaoController.Lista().Select(funcao => new
            {
                Id = funcao.Id,
                Nome = funcao.Nome,
                Departamento = funcao.Departamento.Nome
            }).ToList();
            dataGridViewFuncoes.DataSource = lista;

            // Renomeia as colunas do DataGridView

            dataGridViewFuncoes.Columns[0].HeaderText = "ID";
            dataGridViewFuncoes.Columns[0].Name = "ID";
            dataGridViewFuncoes.Columns[1].HeaderText = "NOME";
            dataGridViewFuncoes.Columns[2].HeaderText = "DEPARTAMENTO";
            dataGridViewFuncoes.Columns[3].HeaderText = "FUNCIONÁRIOS";

            
            dataGridViewFuncoes.Columns[3].Visible = false;
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncoes form = new TelaCadastroFuncoes();
            form.ShowDialog();
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
                FuncaoController funcaoController = new FuncaoController();
                Funcao funcao = funcaoController.BuscaPorId(id);
                var form = new TelaCadastroFuncoes(funcao);
                form.ShowDialog();
                configuraDataGridView();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (verificaId())
            {
                FuncaoController funcaoController = new FuncaoController();
                Funcao funcao = funcaoController.BuscaPorId(id);
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Ponto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    funcaoController.Remove(funcao);
                }

                configuraDataGridView();
            }
        }

        private void dataGridViewFuncoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewFuncoes["ID", e.RowIndex].Value);
        }

        private void dataGridViewFuncoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                id = Convert.ToInt32(dataGridViewFuncoes["ID", e.RowIndex].Value);
                FuncaoController funcaoController = new FuncaoController();
                Funcao funcao = funcaoController.BuscaPorId(id);
                var form = new TelaCadastroFuncoes(funcao);
                form.ShowDialog();
                configuraDataGridView();
        }
    }
}
