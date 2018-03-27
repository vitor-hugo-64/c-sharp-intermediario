using System;
using Biblioteca; // DESSA FORMA SE USA UM PROJETO QUE JÁ ESTÁ REFERENCIADO

namespace Referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conta.somar( 1, 2));
            Console.ReadKey();
        }
    }
}
