using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace LojaWeb.DAO
{
    public class FuncionarioDao
    {
        private Contexto contexto;

        public FuncionarioDao()
        {
            contexto = new Contexto();
        }
        public void Salvar(Funcionario funcionario)
        {
            contexto.Funcionario.Add(funcionario);
            contexto.SaveChanges();
        }

        public Funcionario BuscaPorId(int id)
        {
            return contexto.Funcionario.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Funcionario funcionario)
        {
            contexto.Funcionario.Remove(funcionario);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public IList<Funcionario> Lista()
        {
            var busca = from d in contexto.Funcionario
                        select d;

            return busca.ToList();
        }
    }
}