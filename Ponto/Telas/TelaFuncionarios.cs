using LojaWeb.DAO;
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
    public partial class TelaFuncionarios : Form
    {
        int id;
        public TelaFuncionarios()
        {
            InitializeComponent();
            configuraDataGridView();
        }

        private void buttonIncuirFuncionario_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionarios telaAddFuncionarios = new TelaCadastroFuncionarios();
            telaAddFuncionarios.ShowDialog();
            configuraDataGridView();
        }

        public void configuraDataGridView()
        {
            FuncionariosController funcionarioController = new FuncionariosController();

                var lista = funcionarioController.Lista().Select(funcionario => new
                {
                    Id = funcionario.Id,
                    Nome = funcionario.Nome,
                    Cpf = funcionario.Cpf,
                    Senha = funcionario.Senha,
                    Foto = funcionario.Foto,
                    CargaHorariaDiaria = funcionario.CargaHorariaDiaria,
                    CargaHorariaSemanal = funcionario.CargaHorariaSemanal,
                    Admissao = funcionario.Admissao,
                    Demissao = funcionario.Demissao,
                    Situacao = funcionario.Situacao,
                    Funcao = funcionario.Funcao.Nome,
                    Departamento = funcionario.Departamento.Nome,
                }).ToList();

                dataGridViewFuncionarios.DataSource = lista;
                // Renomeia as colunas do DataGridView
            dataGridViewFuncionarios.Columns[0].HeaderText = "ID";
            dataGridViewFuncionarios.Columns[0].Name = "ID";
            dataGridViewFuncionarios.Columns[1].HeaderText = "NOME";
            dataGridViewFuncionarios.Columns[2].HeaderText = "CPF";
            dataGridViewFuncionarios.Columns[3].HeaderText = "SENHA";
            dataGridViewFuncionarios.Columns[4].HeaderText = "FOTO";
            dataGridViewFuncionarios.Columns[5].HeaderText = "C.H. DIÁRIA";
            dataGridViewFuncionarios.Columns[6].HeaderText = "C.H. SEMANAL";
            dataGridViewFuncionarios.Columns[7].HeaderText = "ADMISSÃO";
            dataGridViewFuncionarios.Columns[8].HeaderText = "DEMISSÃO";
            dataGridViewFuncionarios.Columns[9].HeaderText = "SITUAÇÃO";
            dataGridViewFuncionarios.Columns[10].HeaderText = "FUNÇÃO";
            dataGridViewFuncionarios.Columns[11].HeaderText = "DEPARTAMENTO";
            dataGridViewFuncionarios.Columns[12].HeaderText = "HISTÓRICOS";

            //  Tamanho das colunas

            //dataGridViewFuncionarios.Columns[0].Width = 250;
            //dataGridViewFuncionarios.Columns[1].Width = 100;

            // Oculta colunas desnecessárias
            dataGridViewFuncionarios.Columns[3].Visible = false;
            dataGridViewFuncionarios.Columns[4].Visible = false;
            dataGridViewFuncionarios.Columns[12].Visible = false;

        }

        private void buttonAlterarFuncionario_Click(object sender, EventArgs e)
        {
            if (verificaId())
            {
                FuncionariosController funcionariosController = new FuncionariosController();
                Funcionario funcionario = funcionariosController.BuscaPorId(id);
                var form = new TelaCadastroFuncionarios(funcionario);
                form.ShowDialog();
                configuraDataGridView();
            }
        }

        private void dataGridViewFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewFuncionarios["ID", e.RowIndex].Value);
            FuncionariosController funcionariosController = new FuncionariosController();
            Funcionario funcionario = funcionariosController.BuscaPorId(id);
            var form = new TelaCadastroFuncionarios(funcionario);
            form.ShowDialog();
            configuraDataGridView();
        }

        private void dataGridViewFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewFuncionarios["ID", e.RowIndex].Value);
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

        private void buttonExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (verificaId())
            {
                FuncionariosController funcionariosController = new FuncionariosController();
                Funcionario funcionario = funcionariosController.BuscaPorId(id);
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Ponto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    funcionariosController.delFuncionario(funcionario);
                }

                configuraDataGridView();
            }
        }
    }
}
