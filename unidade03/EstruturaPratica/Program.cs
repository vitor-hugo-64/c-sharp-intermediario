using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Polegada p = new Polegada(10);
            Console.WriteLine(p.getPolegadaCentimetro());
            Console.ReadKey();
        }
    }
}
