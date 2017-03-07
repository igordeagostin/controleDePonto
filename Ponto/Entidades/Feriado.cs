using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Entidades
{
    public class Feriado
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime Data { get; set; }
    }
}
