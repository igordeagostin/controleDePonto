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
    public partial class TelaCadastroFuncionarios : Form
    {
        int id;
        public TelaCadastroFuncionarios()
        {
            InitializeComponent();
            DepartamentoController deparamentoController = new DepartamentoController();
            comboBoxDepartamentos.DataSource = deparamentoController.Lista();
            comboBoxDepartamentos.DisplayMember = "Nome";
            comboBoxDepartamentos.SelectedIndex = 0;

            textBoxAdmissao.Enabled = false;
            textBoxDemissao.Enabled = false;
        }

        public TelaCadastroFuncionarios(Funcionario funcionario)
        {
            InitializeComponent();

            id = funcionario.Id;
            textBoxNome.Text = funcionario.Nome;

            DepartamentoController deparamentoController = new DepartamentoController();
            comboBoxDepartamentos.DataSource = deparamentoController.Lista();
            comboBoxDepartamentos.DisplayMember = "Nome";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = id;
            funcionario.Nome = textBoxNome.Text;
            funcionario.Senha = textBoxSenha.Text;
            funcionario.Cpf = textBoxCPF.Text;
            funcionario.CargaHorariaDiaria = float.Parse(textBoxCHDiaria.Text);
            funcionario.CargaHorariaSemanal = float.Parse(textBoxSemanal.Text);
            funcionario.Admissao = Convert.ToDateTime(textBoxAdmissao.Text);

            FuncionariosController funcionarioController = new FuncionariosController();
            funcionarioController.addFuncionario(funcionario);
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncaoController funcaoController = new FuncaoController();
            comboBoxFuncoes.DataSource = funcaoController.funcaoPorDepartamento(comboBoxDepartamentos.Text);
            comboBoxFuncoes.DisplayMember = "Nome";
        }

        private void TelaCadastroFuncionarios_Activated(object sender, EventArgs e)
        {
            FuncaoController funcaoController = new FuncaoController();
            comboBoxFuncoes.DataSource = funcaoController.funcaoPorDepartamento(comboBoxDepartamentos.Text);
            comboBoxFuncoes.DisplayMember = "Nome";
        }

        private void comboBoxSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSituacao.Text == "CONTRATADO")
            {
                textBoxAdmissao.Enabled = true;
                textBoxDemissao.Enabled = false;
            }
            else if (comboBoxSituacao.Text == "DEMITIDO")
            {
                textBoxAdmissao.Enabled = false;
                textBoxDemissao.Enabled = true;
            }
        }
    }
}
