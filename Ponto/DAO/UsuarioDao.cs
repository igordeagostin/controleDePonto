using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class UsuarioDao
    {
        private Contexto contexto;

        public UsuarioDao()
        {
            contexto = new Contexto();
        }
        public void Salvar(Usuario usuario)
        {
            contexto.Usuario.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuario.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuario.Remove(usuario);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

    }
}