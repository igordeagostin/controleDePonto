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
    public partial class TelaCadastroFuncoes : Form
    {
        int id;
        public TelaCadastroFuncoes()
        {
            InitializeComponent();
            DepartamentoController deparamentoController = new DepartamentoController();
            comboBoxDepartamentos.DataSource = deparamentoController.Lista();
            comboBoxDepartamentos.DisplayMember = "Nome";
        }

        public TelaCadastroFuncoes(Funcao funcao)
        {
            InitializeComponent();

            id = funcao.Id;
            textBoxNome.Text = funcao.Nome;
 
            DepartamentoController deparamentoController = new DepartamentoController();
            comboBoxDepartamentos.DataSource = deparamentoController.Lista();
            comboBoxDepartamentos.DisplayMember = "Nome";
            comboBoxDepartamentos.SelectedIndex = comboBoxDepartamentos.FindStringExact(funcao.Departamento.Nome);

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            FuncaoController funcaoController = new FuncaoController();
            Funcao funcao;

            if(funcaoController.BuscaPorId(id) != null)
            {
                funcao = funcaoController.BuscaPorId(id);
            }
            else
            {
                funcao = new Funcao();
            }
            
            funcao.Nome = textBoxNome.Text;
            var departamento = (Departamento) comboBoxDepartamentos.SelectedItem;
            funcao.DepartamentoId = departamento.Id;
            funcaoController.SaveOrUpdate(funcao);
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
