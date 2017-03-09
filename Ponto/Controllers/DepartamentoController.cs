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
    public class DepartamentoController
    {
        DepartamentoDao departamentoDAO;
        public DepartamentoController()
        {
            departamentoDAO = new DepartamentoDao();
        }
        public void SaveOrUpdate(Departamento departamento)
        {
            departamentoDAO.Salvar(departamento);
        }
        public void Remove(Departamento departamento)
        {
            FuncionarioDao funcionarioDao = new FuncionarioDao();
            FuncaoDao funcaoDao = new FuncaoDao();

            if ((funcionarioDao.QtdUtilizada(departamento.Id) > 0) || (funcaoDao.QtdUtilizada(departamento.Id) > 0))
            {
                MessageBox.Show("Falha ao excluir Função! Motivo:\nO departamento '" + departamento.Nome + "' está sendo usado.");
            }
            else
            {
                departamentoDAO.Remove(departamento);
            }   
        }

        public Departamento BuscaPorId(int id)
        {
            return departamentoDAO.BuscaPorId(id);
        }

        public IList<Departamento> Lista()
        {
            return departamentoDAO.Lista();
        }

    }
}
