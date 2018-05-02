using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Importa a classe que ajuda a criar arquivos e editalos

namespace EscreverArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui voce cria uma objeto de arquivo e informa um determinado endereço para salva-lo e em seguida informa o nome e a extensão do arquivo que deseja criar
            StreamWriter arquivo = new StreamWriter("C:\\Users\\vitor hugo.LIBERATO_ADM\\Documents\\Visual Studio 2017\\projects\\c-sharp-intermediario\\arquivo\\texto.txt");

            // conteúdo que se deseja escrever no arquivo
            arquivo.WriteLine("Olá Este é o meu primeiro arquivo");
            arquivo.WriteLine("Bem vindo a 2017! Desejo o melhor ano das suas vidas");
            arquivo.Close();

            Console.WriteLine("Arquivo Gravado");

            Console.ReadKey();
        }
    }
}
