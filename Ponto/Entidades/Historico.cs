using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Entidades
{
    public class Historico
    {
        public virtual int Id { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual DateTime Dia { get; set; }
        public virtual DateTime HoraEntrada { get; set; }
        public virtual DateTime HoraSaida { get; set; }
    }
}
