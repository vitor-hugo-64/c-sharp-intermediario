using System;

namespace ReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa = new Pessoas();

            // pessoa.nome = ""; Vai dar erro pois a variável é do tipo 'readonly'
        }
    }
}
