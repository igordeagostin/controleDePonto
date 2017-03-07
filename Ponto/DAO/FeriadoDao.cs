using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class FeriadoDao
    {
        private Contexto contexto;

        public FeriadoDao()
        {
            contexto = new Contexto();
        }
        public void Salvar(Feriado feriado)
        {
            contexto.Feriado.Add(feriado);
            contexto.SaveChanges();
        }

        public Feriado BuscaPorId(int id)
        {
            return contexto.Feriado.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Feriado feriado)
        {
            contexto.Feriado.Remove(feriado);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

    }
}