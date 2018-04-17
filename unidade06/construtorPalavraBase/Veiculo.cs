using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtorPalavraBase
{
    class Veiculo
    {
        public Veiculo() // aqui temos um construtor simples
        {
            Console.WriteLine("Construindo Veículo!");
        }

        public Veiculo(string V) // aqui temos um construtor que recebe parametro
        {
            Console.WriteLine("Construindo Veículo: " + V);
        }
    }
}
