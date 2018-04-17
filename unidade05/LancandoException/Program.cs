using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancandoException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número 1: ");
            string numero = Console.ReadLine();

            if (numero == "1")
            {
                Console.WriteLine("Correto");
            } else
            {
                // essa linha gera um erro com a mensagem que está dentro do parenteses
                throw new Exception("O valor digitado não é válido!");
                Console.WriteLine("Errado!");
            }

            Console.ReadKey();
        }
    }
}
