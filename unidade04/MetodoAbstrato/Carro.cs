using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodoAbstrato.lib;

namespace MetodoAbstrato
{
    class Carro : Veiculo
    {
        // então na classe filha que está herdando a classe pai é feito a implementação
        public override void locomover(byte marchar)
        {
            throw new NotImplementedException();
        }
    }
}
