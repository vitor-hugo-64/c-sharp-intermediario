using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.model
{
    public sealed class Funcionario : Pessoa
    {
        public string cargo { get; set; }
        public double salario { get; set; }
        public DateTime dataContratacao { get; set; }
    }
}
