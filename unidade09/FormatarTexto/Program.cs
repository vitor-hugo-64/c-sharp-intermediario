using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Vitor Hugo", ano = "2017";

            // recurso novo do csharp onde já pode ser informado a localização da palavra
            Console.WriteLine($"Meu nome é {nome} o ano é {ano}");

            Console.ReadKey();
        }
    }
}
