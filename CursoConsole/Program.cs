using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CursoConsole;

namespace CursoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> ListCli = new List<Cliente>();
            List<Produto> ListPrd = new List<Produto>();

            Cliente cliente = new Cliente();
            Produto produto = new Produto();

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
                        Console.WriteLine ("1 - Cadastrar Cliente");
                        Console.WriteLine ("2 - Consultar Cliente");
                        Console.WriteLine ("3 - Consultar Cliente por Nome");
                        Console.WriteLine ("4 - Remover Cliente");
                        break;

                    case 2:
                        Console.WriteLine ("1 - Cadastrar Produto");
                        Console.WriteLine ("2 - Consultar Produto");
                        Console.WriteLine ("3 - Consultar Produto por Nome");
                        Console.WriteLine ("4 - Remover Produto");
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
                        Console.Write("Informe o CPF: ");
                        cliente.cpf = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Informe o nome: ");
                        cliente.nome = Console.ReadLine();
                        Console.Write("Informe o Sexo: ");
                        cliente.sexo = Convert.ToChar(Console.ReadLine());
                        Console.Write("Informe a Idade: ");
                        cliente.idade = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o Endereço: ");
                        cliente.endereco = Console.ReadLine();
                        Console.Write("Informe o Telefone: ");
                        cliente.telefone = Convert.ToInt64(Console.ReadLine());
                        ListCli.Add(cliente);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }

                    else if ((operacao.Equals(2)))
                    {
                        Console.WriteLine("Clientes Cadastrados");

                        foreach (Cliente cli in ListCli){
                            Console.WriteLine("");
                            Console.WriteLine("CPF: " + cli.cpf);
                            Console.WriteLine("Nome: " + cli.nome);
                            Console.WriteLine("Idade: " + cli.idade);
                            Console.WriteLine("Sexo: " + cli.sexo);
                            Console.WriteLine("Endereço: " + cli.endereco);
                            Console.WriteLine("Telefone: " + cli.telefone);
                        }
                        Console.ReadKey();
                    }

                    else if ((operacao.Equals(3)))
                    {
                        Console.WriteLine("Informe o nome para busca: ");
                        String nomeaux = Console.ReadLine();

                        foreach (var item in ListCli) {
                            if (item.nome.Equals(nomeaux)){
                                Console.WriteLine("Nome: " + item.nome);
                            }
                        }
                        Console.ReadKey();
                    }

                    else if ((operacao.Equals(4)))
                    {
                        Console.WriteLine("Nome do Cliente a ser removido: ");
                        String nomeaux = Console.ReadLine();
                        foreach (var item in ListCli)
                        {
                            if (item.nome.Equals(nomeaux)){
                                ListCli.Remove(item);
                                Console.WriteLine("Cliente removido com sucesso.");
                                break;
                            }
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
                        Console.Write("Codigo: ");
                        produto.codigo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Descrição: ");
                        produto.descricao = Console.ReadLine();
                        Console.Write("Codigo: ");
                        produto.fabricante = Console.ReadLine();
                        Console.Write("Valor: R$ ");
                        produto.valor = float.Parse(Console.ReadLine());
                        ListPrd.Add(produto);
                        Console.WriteLine("Produto Adicionado com Sucesso");
                    }

                    else if ((operacao.Equals(2)))
                    {

                        foreach (var prd in ListPrd)
                        {
                            Console.WriteLine("Codigo: " + prd.codigo);
                            Console.WriteLine("Produto: " + prd.descricao);
                            Console.WriteLine("Fabricante: " + prd.fabricante);
                            Console.WriteLine("Valor:R$ " + prd.valor);
                        }

                        Console.ReadKey();
                    }

                    else if ((operacao.Equals(3)))
                    {
                        Console.WriteLine("Nome do Produto para busca: ");
                        String produtoaux = Console.ReadLine();
                        foreach (var item in ListPrd)
                        {
                            if (item.descricao.Equals(produtoaux))
                            {
                                Console.WriteLine("Código: " + item.codigo);
                                Console.WriteLine("Descrição: " + item.descricao);
                                Console.WriteLine("Fabricante: " + item.fabricante);
                                Console.WriteLine("Valor: R$ " + item.valor);
                                Console.ReadKey();
                            }
                        }
                    }

                    else if ((operacao.Equals(4)))
                    {
                        Console.WriteLine("Nome do Produto a ser removido: ");
                        String produtoaux = Console.ReadLine();

                        foreach (var prod in ListPrd)
                        {
                            if (prod.descricao.Equals(produtoaux))
                            {
                                ListPrd.Remove(prod);
                                Console.WriteLine("Produto removido com sucesso!");
                                break;
                            }
                        }
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }

            } while (opcao != 3); //fim
        }
    }
}
