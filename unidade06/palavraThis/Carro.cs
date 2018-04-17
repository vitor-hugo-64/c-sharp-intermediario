using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palavraThis
{
    class Carro
    {
        private string marca;

        public void setMarca(string marca)
        {
            this.marca = marca; // a palavra 'this' serve para esse casos aonde precisa referenciar a própria classe para acessar uma determinada variável ou até mesmo método
        }
    }
}
