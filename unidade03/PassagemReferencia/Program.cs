using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 10;
            Console.WriteLine("alterarValor > valor > " + valor); // aqui irá printar o primeiro valor
            alterarValor(ref valor); // aqui ira executar a função passando o valor por referencia
            Console.WriteLine("alterarValor > valor > " + valor); // como a passagem é por referencia o valor original será mudado
            Console.ReadKey();
        }

        public static void alterarValor(ref int valor) // aqui a função só vai permitir passagem por referencia
        {
            Console.WriteLine("alterarValor > valor > " + valor);
            valor += 10;
            Console.WriteLine("alterarValor > valor > " + valor);
        }
    }
}
