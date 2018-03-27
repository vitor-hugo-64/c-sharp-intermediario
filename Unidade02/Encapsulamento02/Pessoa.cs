using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento02
{
    class Pessoa
    {
        public string nome { get; private set; } // ISSO SERVE PARA PERSONALISAR OS GETS E OS SETS
        public byte idade { get; private set; } // nesse caso ele irá permitir somente o get da 'idade' mas não o set

        //OUTRA MANEIRA DE CRIAR get e set PERSONALIZADO É ASSIM
        private string _nome;
        public string Nome { get { return _nome; } set { _nome = value; } }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome(byte nome)
        {
            return this.nome;
        }

        public void setIdade(byte idade)
        {
            this.idade = idade;
        }

        public byte getIdade()
        {
            return this.idade;
        }
    }
}
