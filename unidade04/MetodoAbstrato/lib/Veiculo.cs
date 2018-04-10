using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbstrato.lib
{
    abstract class Veiculo
    {
        // métodos abstratos só servem para serem herdados e serem implementads de uma maneira diferente em cada objeto
        // eles só podem ser definidos em classes abstratas
        // é na classe pai ele só é definido como no exemplo abaixo
        abstract public void locomover(byte marchar);
    }
}
