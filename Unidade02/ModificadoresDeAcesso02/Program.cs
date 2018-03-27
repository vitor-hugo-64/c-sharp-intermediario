using System;
using ModificadoresDeAcesso.lib;

namespace ModificadoresDeAcesso02
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            // veiculo.cor = "vermelho"; Essa linha gera erro pois o atributo cor é 'internal'
        }
    }
}
