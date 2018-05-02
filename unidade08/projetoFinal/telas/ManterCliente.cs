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
    class ManterCliente
    {
        public void cadastrarCliente()
        {
            Cliente c = new Cliente();
            Console.Clear();
            Console.WriteLine("CADASTRAR CLIENTE");
            Console.Write("Nome: ");
            c.nome = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            c.dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("telefone: ");
            c.telefone = Console.ReadLine();
            Console.Write("RG: ");
            c.rg = Console.ReadLine();
            Console.Write("CPF: ");
            c.cpf = Console.ReadLine();
            Console.Write("CEP: ");
            c.cep = int.Parse(Console.ReadLine());
            Console.Write("Estado: ");
            c.estado = Console.ReadLine();
            Console.Write("Cidade: ");
            c.cidade = Console.ReadLine();
            Console.Write("Endereco: ");
            c.endereco = Console.ReadLine();

            GerenciadorArquivo.gravarArquivo("Cliente", ClienteTexto.ConverterParaTexto(c));

            Console.WriteLine("Cadastrado com Sucesso!");
        }

        public void listarClientes()
        {
            Console.Clear();

            Console.WriteLine("Listagem de Clientes");

            string[] l = GerenciadorArquivo.lerArquivo("cliente");

            foreach(string linha in l)
            {
                Cliente c = conversores.ClienteTexto.converterParaCliente(linha);
                Console.WriteLine("NOME: " + c.nome);
            }
            Console.WriteLine("");
        }
    }
}
