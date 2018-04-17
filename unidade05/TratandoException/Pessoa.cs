using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratandoException
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        private string CEP;

        public void setCep(string CEP)
        {
            int resultado;
            int.Parse(CEP);

            // aqui se configura a classe para gerar exception caso de algum erro!
            if(int.TryParse(CEP, out resultado))
            {
                this.CEP = CEP;
            } else
            {
                throw new Exception("CEP Inválido");
            }
        }
    }
}
