using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace LojaWeb.DAO
{
    public class DepartamentoDao
    {
        private Contexto contexto;

        public DepartamentoDao()
        {
            contexto = new Contexto();
        }
        public void Salvar(Departamento departamento)
        {
            contexto.Departamento.Add(departamento);
            contexto.SaveChanges();
        }

        public Departamento BuscaPorId(int id)
        {
            return contexto.Departamento.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Departamento departamento)
        {
            contexto.Departamento.Remove(departamento);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public IList<Departamento> Lista()
        {
            var busca = from d in contexto.Departamento
                        select d;

            return busca.ToList();
        }
    }
}