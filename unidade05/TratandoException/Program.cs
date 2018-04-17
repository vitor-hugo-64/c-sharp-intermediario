using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratandoException
{
    class Program
    {
        static void Main(string[] args)
        {
            // nesse bloco o erro é tratado
            try // código que pode gerar erro vai nesse bloco
            {
                Pessoa p = new Pessoa();
                p.setCep("abc10");
            }
            catch (FormatException fe) // caso gere um erro especifico de conversão esse bloco irá executar
            {
                Console.WriteLine("ERRO FORMAT:" + fe.Message);
            }
            catch (Exception excep) // caso gere qualquer outro erro esse bloco irá executar
            {
                Console.WriteLine("ERRO: " + excep.Message);
            }
            finally // bloco que será executado mesmo que gere ou não gere erro
            {
                Console.WriteLine("Aplicação Encerrada!");
            }
            Console.ReadKey();

            // é sempre importante lembrar que a classe exception é a classe mais básica de erros
            // então o seu bloco sempre será o ultimo a ir no tratamento
            // porque se for primeiro ela não deixara os bloco de tratamento mais especifico executar, justamente porque ela trata qualquer erro
        }
    }
}
