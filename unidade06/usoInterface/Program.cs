using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            SobreVeiculo(c);
            SobreTransporte(c);
            Console.ReadKey();
        }

        static void SobreVeiculo(Veiculo v) // aqui um objeto do tipo Veiculo ou que herde a classe Veiculo podera ser atribuida
        {
            Console.WriteLine(v.marca);
        }

        static void SobreTransporte(ITransporte t) // aqui qualquer objeto que implemente a interface ITransporte pode ser informado
        {
            t.andar();
        }
    }
}
