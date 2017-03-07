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
    public partial class TelaCadastroDepartamento : Form
    {
        int id;
        public TelaCadastroDepartamento()
        {
            InitializeComponent();
        }
        public TelaCadastroDepartamento(Departamento departamento)
        {
            InitializeComponent();
            id = departamento.Id;
            textBoxNome.Text = departamento.Nome;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            DepartamentoController departamentoController = new DepartamentoController();
            Departamento departamento = new Departamento();

            departamento.Id = id;
            departamento.Nome = textBoxNome.Text;
            departamentoController.SaveOrUpdate(departamento);
            Close();
        }
    }
}
