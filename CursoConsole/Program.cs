using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CursoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String cliente = "", produto = "";
            List<string> ListCli = new List<string>();
            ArrayList ListPrd = new ArrayList();

            int opcao, operacao;
            do
            {
                Console.Clear();
                Console.WriteLine("1- Cliente");
                Console.WriteLine("2- Produto");
                Console.WriteLine("3- Sair");
                
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("1 - Cadastrar Cliente");
                        Console.WriteLine("2 - Consultar Cliente");
                        Console.WriteLine("3 - Consultar Cliente por Nome");
                        break;
                    case 2:
                        Console.WriteLine("1 - Cadastrar Produto");
                        Console.WriteLine("2 - Consultar Produto");
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
                if ((opcao.Equals(1)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe o nome:");
                        cliente = Console.ReadLine();
                        ListCli.Add(cliente);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    else if ((operacao.Equals(2)))
                    {
                        Console.WriteLine("Clientes Cadastrados: ");

                        foreach (String cli in ListCli){
                            Console.WriteLine("Cliente: " + cli);
                        }

                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
                else if ((opcao.Equals(2)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe  o nome:");
                        produto = Console.ReadLine();
                        ListPrd.Add(produto);
                        Console.WriteLine("Produto cadastrado com sucesso!");
                    }
                    else if ((operacao.Equals(2)))
                    {
                        Console.Write("Descrição: " + produto);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
            } while (opcao != 3);
        }
    }
}
