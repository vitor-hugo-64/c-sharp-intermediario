using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object b = a; // boxing - a variavel 'b' que é do tipo object consegue receber um tipo primitivo que é uma estrutura e isso é convertido para uma referencia que se chama boxing(conversão de valueType para object)

            int c = (int)b; // unboxing - processo reverso
        }
    }
}
