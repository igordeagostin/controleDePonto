using Ponto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto
{
    public class Contexto : DbContext
    {
        public Contexto()
                     : base("Contexto")
        {

        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Feriado> Feriado { get; set; }
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
