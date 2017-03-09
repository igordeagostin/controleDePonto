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
    public class HistoricoController
    {
        HistoricoDao historicoDao;
        public HistoricoController()
        {
            historicoDao = new HistoricoDao();
        }
        public void SaveOrUpdate(Historico historico)
        {
            historicoDao.Salvar(historico);
        }
        public void Remove(Historico historico)
        {
            historicoDao.Remove(historico);           
        }

        public Historico BuscaPorId(int id)
        {
            return historicoDao.BuscaPorId(id);
        }

        public IList<Historico> Lista()
        {
            return historicoDao.Lista();
        }
    }
}
