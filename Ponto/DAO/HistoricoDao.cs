using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class HistoricoDao
    {
        private Contexto contexto;

        public HistoricoDao()
        {
            contexto = new Contexto();
        }
        public void Salvar(Historico historico)
        {
            contexto.Historico.Add(historico);
            contexto.SaveChanges();
        }

        public Historico BuscaPorId(int id)
        {
            return contexto.Historico.FirstOrDefault(u => u.Id == id);
        }
        public void Remove(Historico historico)
        {
            contexto.Historico.Remove(historico);
            contexto.SaveChanges();
        }
        public IList<Historico> Lista()
        {
            var busca = from d in contexto.Historico
                        select d;

            return busca.ToList();
        }
    }
}