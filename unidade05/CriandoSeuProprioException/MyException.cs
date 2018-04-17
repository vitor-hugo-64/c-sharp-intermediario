using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoSeuProprioException
{
    // essa é a classe de erro personalizada
    class MyException : System.Exception
    {
        string linhaDoErro; // pode ser criado atributos

        // e aqui temos o construtor
        public MyException(string linhaDoErro) : base("Minha Exception") // nessa parte ele está pegando o construtor da classe pai com a palavra reservada 'base' e dentro do parenteses está a mensagem do erro
        {
            this.linhaDoErro = linhaDoErro;
        }
    }
}
