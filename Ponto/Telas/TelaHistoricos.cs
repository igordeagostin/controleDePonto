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
    public partial class TelaHistoricos : Form
    {
        int id;
        public TelaHistoricos()
        {
            InitializeComponent();
            configuraDataGridView();
        }

        public void configuraDataGridView()
        {
            HistoricoController historicoController = new HistoricoController();

            var lista = historicoController.Lista().Select(historico => new
            {
                Id = historico.Id,
                Funcionario = historico.Funcionario.Nome,
                Dia = historico.Dia,
                HoraEntrada = historico.HoraEntrada,
                HoraSaida = historico.HoraSaida
            }).ToList();
            dataGridViewHistoricos.DataSource = lista;

            // Renomeia as colunas do DataGridView

            dataGridViewHistoricos.Columns[0].HeaderText = "ID";
            dataGridViewHistoricos.Columns[0].Name = "ID";
            dataGridViewHistoricos.Columns[1].HeaderText = "FUNCIONARIOS";
            dataGridViewHistoricos.Columns[2].HeaderText = "DATA";
            dataGridViewHistoricos.Columns[3].HeaderText = "HORA DE ENTRADA";
            dataGridViewHistoricos.Columns[3].HeaderText = "HORA DE SAÍDA";

            dataGridViewHistoricos.Columns[3].Visible = false;
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncoes form = new TelaCadastroFuncoes();
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
            id = Convert.ToInt32(dataGridViewHistoricos["ID", e.RowIndex].Value);
        }

        private void dataGridViewFuncoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                id = Convert.ToInt32(dataGridViewHistoricos["ID", e.RowIndex].Value);
                FuncaoController funcaoController = new FuncaoController();
                Funcao funcao = funcaoController.BuscaPorId(id);
                var form = new TelaCadastroFuncoes(funcao);
                form.ShowDialog();
                configuraDataGridView();
        }
    }
}
