using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemParams
{
    class Program
    {
        static void Main(string[] args)
        {
            parametros("Vitor", "Hugo", "Balon", "de", "Oliveira");
        }

        static void parametros(params String[] nomes) // params - permite informar varios valores dentro de uma função e depois todos esse valores serão convertidos em um array com o nome da variavel informado na função
        {                                             // É importante mencionar que se uma função tiver vários parametros o params deve ser o ultimo parametro  

        }
    }
}
