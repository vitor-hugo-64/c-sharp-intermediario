using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresDeAcesso.lib
{
    public class Veiculo
    {
        public string marca; // Modificador de acesso público deixa acessivel para outra classe ou projeto
        protected string modelo; // Esse atributo só será visível pela classe e subclasses
        private DateTime anoFabricacao; // Esse atributo só será visível pela classe
        internal string cor; // Esse atributo será acessível somente dentro do projeto

        void infoVeiculo()
        {
            marca = "Fiat";
            modelo = "ModeloVeiculo";
            Console.WriteLine(marca);
        }

    }
}
