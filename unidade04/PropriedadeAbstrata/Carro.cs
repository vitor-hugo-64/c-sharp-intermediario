using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropriedadeAbstrata.lib;

namespace PropriedadeAbstrata
{
    class Carro : Veiculo
    {
        // e aqui na classe filha os atributos são implementados
        public override string modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int ano => throw new NotImplementedException();
    }
}
