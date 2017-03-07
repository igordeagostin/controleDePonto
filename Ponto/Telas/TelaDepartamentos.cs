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
    public partial class TelaDepartamentos : Form
    {
        int id;
        public TelaDepartamentos()
        {
            InitializeComponent();
            configuraDataGridView();
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastroDepartamento tela = new TelaCadastroDepartamento();
            tela.ShowDialog();
            configuraDataGridView();
        }

        public void configuraDataGridView()
        {
            DepartamentoController departamentoController = new DepartamentoController();
            dataGridViewDepartamentos.DataSource = departamentoController.Lista();
            // Renomeia as colunas do DataGridView

            dataGridViewDepartamentos.Columns[0].HeaderText = "ID";
            dataGridViewDepartamentos.Columns[0].Name = "ID";
            dataGridViewDepartamentos.Columns[1].HeaderText = "NOME";
            dataGridViewDepartamentos.Columns[2].HeaderText = "FUNCIONÁRIOS";
            dataGridViewDepartamentos.Columns[3].HeaderText = "FUNÇÕES";

            dataGridViewDepartamentos.Columns[2].Visible = false;
            dataGridViewDepartamentos.Columns[3].Visible = false;
        }

        private void dataGridViewDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (verificaId())
            {
                DepartamentoController departamentosController = new DepartamentoController();
                Departamento departamento = departamentosController.BuscaPorId(id);
                var form = new TelaCadastroDepartamento(departamento);
                form.ShowDialog();
                configuraDataGridView();
            }
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

        private void dataGridViewDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewDepartamentos["ID", e.RowIndex].Value);
            DepartamentoController departamentosController = new DepartamentoController();
            Departamento departamento = departamentosController.BuscaPorId(id);
            var form = new TelaCadastroDepartamento(departamento);
            form.ShowDialog();
            configuraDataGridView();
        }

        private void dataGridViewDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewDepartamentos["ID", e.RowIndex].Value);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (verificaId())
            {
                DepartamentoController departamentosController = new DepartamentoController();
                Departamento departamento = departamentosController.BuscaPorId(id);
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Ponto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    departamentosController.Remove(departamento);
                }

                configuraDataGridView();
            }
        }
    }
    }
