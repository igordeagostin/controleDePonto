using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Entidades
{
    public class Funcionario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cpf { get; set; }
        public virtual string Senha { get; set; }
        public virtual byte[] Foto { get; set; }
        public virtual float CargaHorariaDiaria { get; set; }
        public virtual float CargaHorariaSemanal { get; set; }        
        public virtual DateTime Admissao { get; set; }
        public virtual DateTime Demissao { get; set; }
        public virtual string Situacao { get; set; }
        public virtual Funcao Funcao { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual ISet<Historico> Historicos { get; set; }
    }
}
