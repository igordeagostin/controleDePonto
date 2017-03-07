using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponto.Entidades;
using LojaWeb.DAO;


namespace Ponto.Controllers
{
    public class FuncionariosController
    {
        FuncionarioDao funcionarioDAO;

        public FuncionariosController()
        {
            funcionarioDAO = new FuncionarioDao();
        }
        public void addFuncionario(Funcionario funcionario)
        {
            funcionarioDAO.Salvar(funcionario);
        }
        public void delFuncionario(Funcionario funcionario)
        {
            funcionarioDAO.Remove(funcionario);
        }

        public Funcionario BuscaPorId(int id)
        {
            return funcionarioDAO.BuscaPorId(id);
        }

        public IList<Funcionario> Lista()
        {
            return funcionarioDAO.Lista();
        }

    }
}
