using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Entidades
{
    public class Funcao
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
    }
}
