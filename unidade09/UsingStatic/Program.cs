using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math; // aqui voce importa os metodos e atributos staticos da classe math

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.Pow(10, 2); // sem o uso importado do static

            Pow(10, 2); // com o uso importado do static
        }
    }
}
