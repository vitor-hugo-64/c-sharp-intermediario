using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pega o endereço do arquivo e armazena em uma variável
            String arquivo = File.ReadAllText("C:\\Users\\vitor hugo.LIBERATO_ADM\\Documents\\Visual Studio 2017\\projects\\c-sharp-intermediario\\arquivo\\texto.txt");

            Console.Write(arquivo);

            /* LER CADA LINHA DO ARRAY */

            // aqui é criado uma array e cada linha do arquivo é um indice do array
            String[] linhas = File.ReadAllLines("C:\\Users\\vitor hugo.LIBERATO_ADM\\Documents\\Visual Studio 2017\\projects\\c-sharp-intermediario\\arquivo\\texto.txt");

            Console.WriteLine("Quantidade De Linhas: " + linhas.Length);

            foreach ( String linha in linhas)
            {
                Console.WriteLine("Linhas: " + linha);
            }

            Console.ReadKey();
        }
    }
}
