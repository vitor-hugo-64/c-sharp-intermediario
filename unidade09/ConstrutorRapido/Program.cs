using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorRapido
{
    class Program
    {
        static void Main(string[] args)
        {
            // dessa maneira se instancia o objeto já atribuindo os valores aos atributos sem precisar criar um construtor na classe
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Modelo Tal", Rodas = "4", DataFabricacao = new DateTime(2010, 10, 10) };
        }
    }
}
