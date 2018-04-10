using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseParcial
{
    partial class Pessoa // isso é a outra metade da classe pessoa
    {
        public string getNome()
        {
            return this.nome;
        }
    }
}
