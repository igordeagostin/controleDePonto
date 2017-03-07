using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponto.Entidades;
using LojaWeb.DAO;

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
            departamentoDAO.Remove(departamento);
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
