using System;
using ModificadoresDeAcesso.lib;

namespace ModificadoresDeAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();

            veiculo.cor = "vermelho"; // É possível pois o atributo cor é internal
            veiculo.marca = "FIAT"; // É possível acessar esse atributo do objeto pois ele é público
            // carro.modelo = "Modelo"; Essa linha apresenta erro pois o atributo 'modelo' é protegido, então só a classe e as subclasses podem acessalo
            // caminhao.anoFabricacao = 1998; Essa linha apresenta erro pois o atributo 'anoFabricacao' é privado, então só a classe pode acessalo

        }
    }
}