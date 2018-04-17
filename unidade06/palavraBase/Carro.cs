using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palavraBase
{
    class Carro : Veiculo
    {
        public override void andar()
        {
            base.andar(); // palavra base serve para referenciar a classe mae, então nesse caso ele está chamando o método andar da classe mae
        }
    }
}
