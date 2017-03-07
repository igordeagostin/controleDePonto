using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponto.Entidades;
using LojaWeb.DAO;

namespace Ponto.Controllers
{
    public class FuncaoController
    {
        FuncaoDao funcaoDAO;
        public FuncaoController()
        {
            
        }
        public void SaveOrUpdate(Funcao funcao)
        {            
        }
        public void Remove(Funcao funcao)
        {
           
        }

        public Funcao BuscaPorId(int id)
        {
            return null;
        }

        public IList<Funcao> Lista()
        {
            return null;
        }

        public IList<Funcao> funcaoPorDepartamento(string nome)
        {
            return null;
        }

    }
}
