using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 10;
            Console.WriteLine("alterarValor > valor > " + valor); 
            alterarValor(out valor); 
            Console.WriteLine("alterarValor > valor > " + valor);
            Console.ReadKey();
        }

        public static void alterarValor(out int valor) // out - é basicamente uma passagem de valor por referencia, mas ele não deixa ler o valor e sim só alterar
        {
            valor = 15; // não pode printar esse valor na tela, pois não é permitido a leitura
        }
    }
}
