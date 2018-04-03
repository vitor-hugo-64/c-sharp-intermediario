using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaPratica
{
    struct Polegada
    {
        double centimetro; // estrutras só podem ter atributos vazios, o valor só devem ser atribuido na hora de instanciar ou depois de instanciar
        double polegada;

        public Polegada( double polegadas ) // Todo construtor de estrutura deve receber parametros de entrada na hora de instanciar, isso é obrigatório
        {
            centimetro = 2.54;
            polegada = centimetro * polegadas;
        }

        public double getPolegadaCentimetro()
        {
            return polegada;
        }
    }
}
