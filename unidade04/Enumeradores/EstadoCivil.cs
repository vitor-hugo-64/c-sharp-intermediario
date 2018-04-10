using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores
{
    // enumerador é como se fosse um conjunto de constantes que serve para ser usado em outras classes
    // é usado a palavra enum
    enum EstadoCivil
    {
        // cada atributo do enumerador ganha um indice de acordo com a ordem em que é declarado
        Solteiro, Casado, Viuvo, Divorciado = 3 // voce tmbém pode definir o indice
    }
}
