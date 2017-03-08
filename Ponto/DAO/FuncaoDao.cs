using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace LojaWeb.DAO
{
    public class FuncaoDao
    {
        private Contexto contexto;

        public FuncaoDao()
        {
            contexto = new Contexto();
        }
        public void Salvar(Funcao funcao)
        {
            if(funcao.Id == 0)
            {
                contexto.Funcao.Add(funcao);
                contexto.SaveChanges();
            }
            else if(funcao.Id > 0)
            {
                contexto.SaveChanges();
            }            
        }

        public Funcao BuscaPorId(int id)
        {
            return contexto.Funcao.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Funcao funcao)
        {
            contexto.Funcao.Remove(funcao);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public IList<Funcao> Lista()
        {
            var busca = from d in contexto.Funcao
                        select d;

            return busca.ToList();
        }
        public IList<Funcao> funcaoPorDepartamento(string nome)
        {
            var busca = from f in contexto.Funcao
                        select f;

            if (!String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(f => f.Departamento.Nome == nome);
            }

            return busca.ToList();
        }
    }
}