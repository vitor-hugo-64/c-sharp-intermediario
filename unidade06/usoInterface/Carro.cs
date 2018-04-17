using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoInterface
{
    class Carro : Veiculo, ITransporte
    {
        public void andar()
        {
            Console.WriteLine("Carro andando...");
        }
    }
}
