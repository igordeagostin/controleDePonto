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
        }
        public void SaveOrUpdate(Departamento departamento)
        {            
           
        }
        public void Remove(Departamento departamento)
        {
           
        }

        public Departamento BuscaPorId(int id)
        {
            return null;
        }

        public IList<Departamento> Lista()
        {
            return null;
        }

    }
}
