using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EstadoCivil.Casado); // nesse caso ele ira mostrar o nome do enumerador ('casado')
            Console.WriteLine((int)EstadoCivil.Casado); // nesse caso irá mostrar o indice, pois está sendo feito um casting( está considerando o enumerador como um numero)
            Console.ReadKey();
        }
    }
}
