using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.cs.lib;

namespace Interface.cs
{
    class Carro : Veiculo, ITransporte
    {
        public override void parar()
        {
            throw new NotImplementedException();
        }

        public void locomover() // aqui é impementado esse metodo popr causa da interface
        {

        }
    }
}
