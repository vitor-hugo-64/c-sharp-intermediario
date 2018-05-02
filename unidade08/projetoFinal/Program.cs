using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoFinal.telas;

namespace projetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Funcionário");
                Console.WriteLine("4 - Listar Funcionários");
                Console.WriteLine("5 - Sair");

                opcao = int.Parse(Console.ReadLine());
                ManterCliente telaCliente = new ManterCliente();
                ManterFuncionario telaFuncionario = new ManterFuncionario();

                switch (opcao)
                {
                    case 1:
                        
                        telaCliente.cadastrarCliente();
                        break;
                    case 2:
                        telaCliente.listarClientes();
                        break;
                    case 3:
                        telaFuncionario.cadastrarFuncionario();
                        break;
                    case 4:
                        telaFuncionario.listarFuncionarios();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

            } while (opcao != 5);
        }
    }
}
