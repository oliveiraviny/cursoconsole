using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, operacao;
            string cliente = "";
            string produto = "";

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cliente");
                Console.WriteLine("2 - Produto");
                Console.WriteLine("3 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("1 - Cadastrar Cliente");
                        Console.WriteLine("2 - Consultar Cliente");
                        break;

                    case 2:
                        Console.WriteLine("1 - Cadastrar Produto");
                        Console.WriteLine("2 - Consultar Produto");
                        break;

                    case 3:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Operação Inválida");
                        break;
                }

                if ((opcao.Equals(1)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.WriteLine("Informe o nome do cliente");
                        cliente = Console.ReadLine();
                    }

                    else if (operacao.Equals(2))
                    {
                        Console.WriteLine("Nome do Cliente: " + cliente);
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine("Operação Inválida");
                    }
                }

                else if ((opcao.Equals(2)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());

                    if (operacao.Equals(1))
                    {
                        Console.WriteLine("Informe o nome");
                        produto = Console.ReadLine();
                    }

                    else if (operacao.Equals(2))
                    {
                        Console.WriteLine("Descrição: " + produto);
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine("Operação Inválida");
                    }
                }
            } while (opcao != 3);
        }
    }
}
