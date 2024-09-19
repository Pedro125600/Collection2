using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4_02
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            int opcao = 0;

            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("Fila de Atendimento - Banco/Supermercado");
                Console.WriteLine("1 - Adicionar um cliente à fila");
                Console.WriteLine("2 - Atender um cliente (remover o primeiro da fila)");
                Console.WriteLine("3 - Exibir o número de clientes na fila");
                Console.WriteLine("4 - Exibir o próximo cliente a ser atendido");
                Console.WriteLine("5 - Encerrar o programa");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome do Cliente: ");
                        string nomeCliente = Console.ReadLine();
                        fila.Enqueue(nomeCliente);
                        Console.WriteLine($"\nCliente {nomeCliente} adicionado à fila.");
                        break;
                    case 2:
                        Console.Clear();
                        if (fila.Count > 0)
                        {
                            string clienteAtendido = fila.Dequeue();
                            Console.WriteLine($"Cliente {clienteAtendido} foi atendido.");
                        }
                        else
                        {
                            Console.WriteLine("Não há clientes na fila.");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Número de clientes na fila: {fila.Count}");
                        break;
                    case 4:
                        if (fila.Count > 0)
                        {
                            string proximoCliente = fila.Peek();
                            Console.WriteLine($"Próximo cliente a ser atendido: {proximoCliente}");
                        }
                        else
                        {
                            Console.WriteLine("Não há clientes na fila.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                if (opcao != 5)
                {
                    Console.WriteLine("\nPressione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}

      
       
       

       