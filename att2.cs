using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> Agenda = new List<string>();


            int opcao = 0;

            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("Agenda de Contatos");
                Console.WriteLine("1 - Adicionar um novo contato");
                Console.WriteLine("2 - Atualizar informações de um contato");
                Console.WriteLine("3 - Excluir um contato da agenda");
                Console.WriteLine("4 - Listar todos os contatos");
                Console.WriteLine("5 - Encerrar o programa");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome do Contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("E-mail: ");
                        string email = Console.ReadLine();

                        string contato = $"{nome} {telefone} {email}";
                        Agenda.Add(contato);

                        Console.WriteLine("\nContato adicionado com sucesso!");
                        break;
                    case 2:
                        Console.Write("Digite o número do contato que deseja atualizar: ");
                        int nun = int.Parse(Console.ReadLine()) - 1;

                        if (nun >= 0 && nun < Agenda.Count)
                        {
                            Console.WriteLine("Atualize as informações:");
                            Console.Write("Nome do Contato: ");
                            nome = Console.ReadLine();
                            Console.Write("Telefone: ");
                            telefone = Console.ReadLine();
                            Console.Write("E-mail: ");
                            email = Console.ReadLine();

                            Agenda[nun] = $"{nome} {telefone} {email}";
                            Console.WriteLine("Contato atualizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }

                        break;
                    case 3:

                        Console.Write("Digite o número do contato que deseja excluir: ");
                        nun = int.Parse(Console.ReadLine()) - 1;

                        if (nun >= 0 && nun < Agenda.Count)
                        {
                            Agenda.RemoveAt(nun);
                            Console.WriteLine("\nContato excluído com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Lista de Contatos:");

                        if (Agenda.Count == 0)
                        {
                            Console.WriteLine("A agenda está vazia.");
                        }
                        else
                        {
                            for (int i = 0; i < Agenda.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} - {Agenda[i]}");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();

            }
        }
    }
}
       

     
    