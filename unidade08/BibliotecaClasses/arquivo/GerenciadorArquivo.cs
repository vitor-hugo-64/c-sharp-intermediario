using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BibliotecaClasses.arquivo
{
    public class GerenciadorArquivo
    {
        public static void gravarArquivo(string nome, string texto)
        {
            string caminho = "C:\\Users\\vitor\\Documents\\" + nome + ".txt";

            if (File.Exists(caminho))
            {
                using (StreamWriter wr = File.AppendText(caminho))
                {
                    wr.WriteLine(texto);
                }
            } else
            {
                using (StreamWriter wr = new StreamWriter(caminho))
                {
                    wr.WriteLine(texto);
                }
            }
        }

        public static string[] lerArquivo(string nome)
        {
            string caminho = "C:\\Users\\vitor\\Documents\\" + nome + ".txt";
            return File.ReadAllLines(caminho);
        }
    }
}
