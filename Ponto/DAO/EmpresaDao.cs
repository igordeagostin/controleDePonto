using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class EmpresaDao
    {
        private Contexto contexto;

        public EmpresaDao()
        {
            contexto = new Contexto();
        }
        public void Salvar(Empresa empresa)
        {
            contexto.Empresa.Add(empresa);
            contexto.SaveChanges();
        }

        public Empresa BuscaPorId(int id)
        {
            return contexto.Empresa.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Empresa empresa)
        {
            contexto.Empresa.Remove(empresa);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

    }
}