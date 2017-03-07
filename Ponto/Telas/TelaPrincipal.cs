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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaFuncionarios telaFuncionarios = new TelaFuncionarios();
            telaFuncionarios.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDepartamentos telaDepartamentos = new TelaDepartamentos();
            telaDepartamentos.ShowDialog();
        }

        private void funçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaFuncoes telaFuncoes = new TelaFuncoes();
            telaFuncoes.ShowDialog();
        }
    }
}
