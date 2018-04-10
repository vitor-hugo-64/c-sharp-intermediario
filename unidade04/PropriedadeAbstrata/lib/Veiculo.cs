using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadeAbstrata.lib
{
    abstract class Veiculo
    {
        // a única coisa que muda do metodo abstrato para o atributo é que o atributo deve ter o gettters e os setters
        abstract public string modelo { get; set; }
        abstract public int ano { get; }
    }
}
