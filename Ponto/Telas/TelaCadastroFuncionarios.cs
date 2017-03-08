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
            textBoxCHDiaria.Text = funcionario.CargaHorariaDiaria.ToString();
            textBoxCPF.Text = funcionario.Cpf;
            textBoxSemanal.Text = funcionario.CargaHorariaSemanal.ToString();
            textBoxSenha.Text = funcionario.Senha;

            if(funcionario.Admissao == DateTime.MinValue)
            {
                textBoxDemissao.Text = funcionario.Demissao.ToString("dd/MM/yyyy");
            }
            else if (funcionario.Demissao == DateTime.MinValue)
            {
                textBoxAdmissao.Text = funcionario.Admissao.ToString("dd/MM/yyyy");
            }
            else
            {
                textBoxDemissao.Text = funcionario.Demissao.ToString("dd/MM/yyyy");
                textBoxAdmissao.Text = funcionario.Admissao.ToString("dd/MM/yyyy");
            }

            //Preenche os combobox
            DepartamentoController deparamentoController = new DepartamentoController();
            comboBoxDepartamentos.DataSource = deparamentoController.Lista();
            comboBoxDepartamentos.DisplayMember = "Nome";
            comboBoxDepartamentos.SelectedIndex = comboBoxDepartamentos.FindStringExact(funcionario.Departamento.Nome);

            FuncaoController funcaoController = new FuncaoController();
            comboBoxFuncoes.DataSource = funcaoController.Lista();
            comboBoxFuncoes.DisplayMember = "Nome";
            comboBoxFuncoes.SelectedIndex = comboBoxFuncoes.FindStringExact(funcionario.Funcao.Nome);

            comboBoxSituacao.SelectedIndex = comboBoxSituacao.FindStringExact(funcionario.Situacao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuncionariosController funcionarioController = new FuncionariosController();
            Funcionario funcionario;

            if (funcionarioController.BuscaPorId(id) != null)
            {
                funcionario = funcionarioController.BuscaPorId(id);
            }
            else
            {
                funcionario = new Funcionario();
            }

            funcionario.Nome = textBoxNome.Text;
            funcionario.Senha = textBoxSenha.Text;
            funcionario.Cpf = textBoxCPF.Text;
            funcionario.CargaHorariaDiaria = float.Parse(textBoxCHDiaria.Text);
            funcionario.CargaHorariaSemanal = float.Parse(textBoxSemanal.Text);

            //Verificando as datas de Admissão e Demissão
            if(textBoxAdmissao.Text == null || textBoxAdmissao.Text == "")
            {
                funcionario.Admissao = DateTime.MinValue;
            }
            else
            {
                funcionario.Admissao = Convert.ToDateTime(textBoxAdmissao.Text);
            }
            if (textBoxDemissao.Text == null || textBoxDemissao.Text == "")
            {
                funcionario.Demissao = DateTime.MinValue;
            }
            else
            {
                funcionario.Demissao = Convert.ToDateTime(textBoxDemissao.Text);
            }

            funcionario.Situacao = comboBoxSituacao.SelectedItem.ToString();

            var departamento = (Departamento)comboBoxDepartamentos.SelectedItem;
            funcionario.DepartamentoId = departamento.Id;

            var funcao = (Funcao)comboBoxFuncoes.SelectedItem;
            funcionario.FuncaoId = funcao.Id;

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

        private void buttonSelecionaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\";
            openFile.RestoreDirectory = true;
            openFile.Title = "Selecionar Imagem";
            openFile.CheckPathExists = true;
            openFile.CheckFileExists = true;
            openFile.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            openFile.ShowDialog();
        }
    }
}
