using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoSeuProprioException
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui o erro é tratado com try cacth
            try
            {
                throw new MyException("Linha 13");
            }
            catch (MyException e) // criamos uma variável do tipo do erro
            {
                Console.WriteLine(e.Message); // exibimos a mensagem na tela
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
