using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscreverArquivoUsandoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // o using serve para criar uma arquivo do mesmo modo que pode ser criado sem ele, porem quando se usa o using é criado um escopo, na qual depois de fechado ira liberar todos os recursos que o seu sistema usou para abrir determinados arquivos
            using (StreamWriter arquivo = new StreamWriter("C:\\Users\\vitor hugo.LIBERATO_ADM\\Documents\\Visual Studio 2017\\projects\\c-sharp-intermediario\\arquivo\\texto.txt"))
            {
                // conteúdo que se deseja escrever no arquivo
                arquivo.WriteLine("Olá Este é o meu primeiro arquivo");
                arquivo.WriteLine("Bem vindo a 2017! Desejo o melhor ano das suas vidas");
            }

            Console.WriteLine("Arquivo Gravado");

            Console.ReadKey();
        }
    }
}
