using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClasses.model;

namespace projetoFinal.conversores
{
    class FuncionarioTexto
    {
        public static string ConverterParaTexto(Funcionario f)
        {
            string texto = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", f.nome, f.dataNascimento, f.telefone, f.cpf, f.rg, f.cep, f.estado, f.cidade, f.endereco, f.cargo, f.salario, f.dataContratacao);
            return texto;
        }

        public static Funcionario converterParaFuncionario(string t)
        {
            string[] e = t.Split(',');

            Funcionario f = new Funcionario();
            f.nome = e[0];
            f.dataNascimento = DateTime.Parse(e[1]);
            f.telefone = e[2];
            f.cpf = e[3];
            f.rg = e[4];
            f.cep = int.Parse(e[5]);
            f.estado = e[6];
            f.cidade = e[7];
            f.endereco = e[8];
            f.cargo = e[9];
            f.salario = double.Parse(e[10]);
            f.dataContratacao = DateTime.Parse(e[11]);

            return f;
        }
    }
}
