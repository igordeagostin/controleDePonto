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
    public class UsuarioController
    {
        UsuarioDao usuarioDAO;
        public UsuarioController()
        {
            usuarioDAO = new UsuarioDao();
        }
        public void SaveOrUpdate(Usuario usuario)
        {
            usuarioDAO.Salvar(usuario);
        }
        public void Remove(Usuario usuario)
        {
            usuarioDAO.Remove(usuario);
        }

        public Usuario BuscaPorId(int id)
        {
            return usuarioDAO.BuscaPorId(id);
        }

        public IList<Usuario> Lista()
        {
            return usuarioDAO.Lista();
        }   
        public bool Login(string login, string senha)
        {
            return usuarioDAO.Login(login, senha);
        }
    }
}
