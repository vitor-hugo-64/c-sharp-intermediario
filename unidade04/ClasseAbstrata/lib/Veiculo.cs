using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    // classe abstrata é um tipo de classe que não pode ser instanciada mas pode ser herdada
    // como no caso da classe veiculo é um tipo de objeto que serve para se locomover, mas não existe o objeto veiculo
    // então é criado a classe carro que irá herdar a classe veiculo, para possa se usar os atributos e metodos dessa classe
    // para tornar uma classe em abstrata se usa a palavra reservada 'abstract'
    abstract class Veiculo
    {
        public void locomover()
        {

        }
    }
}
