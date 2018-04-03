using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 10;
            Console.WriteLine("alterarValor > valor > " + valor); // aqui irá printar o primeiro valor
            alterarValor(valor); // aqui ira executar a função passando o valor da variavel 'valor'
            Console.WriteLine("alterarValor > valor > " + valor); // como a passagem é por valor, será criado uma nova variável dentro da funçõa, então a original vai continuar com o mesmo valor
            Console.ReadKey();
        }

        public static void alterarValor(int valor)
        {
            Console.WriteLine("alterarValor > valor > " + valor);
            valor += 10;
            Console.WriteLine("alterarValor > valor > " + valor);
        }
    }
}
