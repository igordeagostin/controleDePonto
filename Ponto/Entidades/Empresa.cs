using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto.Entidades
{
    public class Empresa
    {
        public virtual int Id { get; set; }
        public virtual string Razaosocial { get; set; }
        public virtual string Cnpj { get; set; }
        public virtual string Ie { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Municipio { get; set; }
        public virtual string Uf { get; set; }
        public virtual string Cep { get; set; }
        public virtual byte[] Logo { get; set; }
    }
}
