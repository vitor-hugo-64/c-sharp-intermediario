using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoParcial
{
    partial class Carro
    {
        partial void FacaAlgo(string andar); // metodos parciais podem ser declarados em um arquivo e sua implementação ser informada em outra classe parcial
                                                // caso o programa seja rodado e o compilador detecte que o metodo só tem a delaração e não a implementação
                                                // ele simplismente irá ignorar a linha, mas não irá gerar erro
                                                // regras para implemnetação de metodos parciais:
                                                    // 1 - Métodos parciais só podem ser privados
                                                    // 2 - Métodos parciais não podem retornar algo, então eles sempre serão 'void'
                                                    // 
    }
}
