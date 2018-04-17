using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtorPalavraBase
{
    class Carro : Veiculo
    {
        // a palavra base no construtor serve para chamar o construtor da classe mae

        public Carro() : base()  // aqui chamamos o construtor simples
        {

        }

        public Carro(string V) : base(V) // e aqui chamamos o construtor com parametro, como o construtor da classe mae tem parametro a classe filha tambem deve ter esse mesmo construtor com parametro caso queira usar o construtor da classe mae
        {
            
        }
    }
}
