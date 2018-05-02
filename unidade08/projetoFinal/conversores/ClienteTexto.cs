using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClasses.model;

namespace projetoFinal.conversores
{
    class ClienteTexto
    {
        public static string ConverterParaTexto(Cliente c)
        {
            string texto = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", c.nome, c.dataNascimento, c.telefone, c.cpf, c.rg, c.cep, c.estado, c.cidade, c.endereco);
            return texto;
        }

        public static Cliente converterParaCliente(string t)
        {
            string[] e = t.Split(',');

            Cliente c = new Cliente();
            c.nome = e[0];
            c.dataNascimento = DateTime.Parse(e[1]);
            c.telefone = e[2];
            c.cpf = e[3];
            c.rg = e[4];
            c.cep = int.Parse(e[5]);
            c.estado = e[6];
            c.cidade = e[7];
            c.endereco = e[8];

            return c;
        }
    }
}
