using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Entidades
{
    public class Departamento
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Funcionario> Funcionario { get; set; }
        public virtual IList<Funcao> Funcao { get; set; }

    }
}
