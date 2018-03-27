using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa = new Pessoas();
            pessoa.setNome("Vitor"); // dessa forma se usa o método daí
            Console.WriteLine(pessoa.getNome()); // busca o valor sem precisar acessar o atributo de forma direta
            Console.ReadKey();
        }
    }
}
