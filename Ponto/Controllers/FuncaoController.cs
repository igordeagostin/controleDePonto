using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponto.Entidades;
using LojaWeb.DAO;
using System.Windows.Forms;

namespace Ponto.Controllers
{
    public class FuncaoController
    {
        FuncaoDao funcaoDAO;
        public FuncaoController()
        {
            funcaoDAO = new FuncaoDao();
        }
        public void SaveOrUpdate(Funcao funcao)
        {
            funcaoDAO.Salvar(funcao);
        }
        public void Remove(Funcao funcao)
        {
            FuncionarioDao funcionarioDao = new FuncionarioDao();

            if (funcionarioDao.QtdUtilizada(funcao.Id) > 0)
            {
                MessageBox.Show("Falha ao excluir Função! Motivo:\nA função '" + funcao.Nome + "' está sendo usada.");
            }
            else
            {
                funcaoDAO.Remove(funcao);
            }
        }

        public Funcao BuscaPorId(int id)
        {
            return funcaoDAO.BuscaPorId(id);
        }

        public IList<Funcao> Lista()
        {
            return funcaoDAO.Lista();
        }
        public IList<Funcao> funcaoPorDepartamento(string nome)
        {
            return funcaoDAO.funcaoPorDepartamento(nome);
        }
    }
}
