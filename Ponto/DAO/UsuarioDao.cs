using Ponto;
using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

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
            if (usuario.Id == 0)
            {
                contexto.Usuario.Add(usuario);
                contexto.SaveChanges();
            }
            else if (usuario.Id > 0)
            {
                contexto.SaveChanges();
            }
            
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

        public IList<Usuario> Lista()
        {
            var busca = from d in contexto.Usuario
                        select d;

            return busca.ToList();
        }
        public bool Login(string login, string senha)
        {
            if(contexto.Usuario.Count(u => u.Login == login && u.Senha == senha) > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("O Login ou Senha estão incorretos.");
                return false;
            }
        }


    }
}