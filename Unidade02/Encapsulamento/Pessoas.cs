using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class Pessoas
    {
        // as regras de encapsulamento visam pricipalmente a segurança das informações então sempre é aconselhado a se deixar os atributos privados e acessalos através de métodos
        private string nome;

        // esse seria o método que insere valores no atributo 'nome'
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        // esse seria o método que retorna o valor do 'nome'
        public string getNome()
        {
            return this.nome;
        }
    }
}
