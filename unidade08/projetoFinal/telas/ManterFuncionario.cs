using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClasses.model;
using BibliotecaClasses.arquivo;
using projetoFinal.conversores;

namespace projetoFinal.telas
{
    class ManterFuncionario
    {
        public void cadastrarFuncionario()
        {
            Funcionario f = new Funcionario();
            Console.Clear();
            Console.WriteLine("CADASTRAR FUNCIONÁRIO");
            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            f.dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("telefone: ");
            f.telefone = Console.ReadLine();
            Console.Write("RG: ");
            f.rg = Console.ReadLine();
            Console.Write("CPF: ");
            f.cpf = Console.ReadLine();
            Console.Write("CEP: ");
            f.cep = int.Parse(Console.ReadLine());
            Console.Write("Estado: ");
            f.estado = Console.ReadLine();
            Console.Write("Cidade: ");
            f.cidade = Console.ReadLine();
            Console.Write("Endereco: ");
            f.endereco = Console.ReadLine();
            Console.Write("Cargo: ");
            f.cargo = Console.ReadLine();
            Console.Write("Salario: ");
            f.salario = double.Parse(Console.ReadLine());
            Console.Write("Data Contratação: ");
            f.dataContratacao = DateTime.Parse(Console.ReadLine());

            GerenciadorArquivo.gravarArquivo("Funcionario", FuncionarioTexto.ConverterParaTexto(f));

            Console.WriteLine("Cadastrado com Sucesso!");

        }

        public void listarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("Listagem de Clientes");

            string[] l = GerenciadorArquivo.lerArquivo("funcionario");

            foreach (string linha in l)
            {
                Funcionario f = conversores.FuncionarioTexto.converterParaFuncionario(linha);
                Console.WriteLine("NOME: " + f.nome);
            }
            Console.WriteLine("");

        }
    }
}
