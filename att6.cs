using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, List<string>> dicionarioSinonimos = new SortedList<string, List<string>>();
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Adicionar uma nova palavra e seus sinônimos");
                Console.WriteLine("2 - Pesquisar os sinônimos de uma palavra");
                Console.WriteLine("3 - Exibir o dicionário em ordem alfabética");
                Console.WriteLine("4 - Encerrar o programa");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a palavra que deseja adicionar: ");
                        string palavra = Console.ReadLine();
                        if (dicionarioSinonimos.ContainsKey(palavra))
                        {
                            Console.WriteLine($"A palavra '{palavra}' já está no dicionário. Adicionando mais sinônimos.");
                        }
                        else
                        {
                            dicionarioSinonimos[palavra] = new List<string>();
                        }
                        Console.Write("Quantos sinônimos deseja adicionar para esta palavra? ");
                        int numSinonimos = int.Parse(Console.ReadLine());

                        for (int i = 0; i < numSinonimos; i++)
                        {
                            Console.Write($"Digite o sinônimo {i + 1}: ");
                            string sinonimo = Console.ReadLine();
                            dicionarioSinonimos[palavra].Add(sinonimo);
                        }

                        break;
                    case 2:
                        Console.Write("Digite a palavra para a qual deseja buscar os sinônimos: ");
                        palavra = Console.ReadLine();

                        if (dicionarioSinonimos.ContainsKey(palavra))
                        {

                            Console.WriteLine($"Sinônimos de '{palavra}':");
                            for(int i = 0;i < dicionarioSinonimos[palavra].Count; i++)
                            {
                                Console.Write(dicionarioSinonimos[palavra][i] + " ");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"A palavra '{palavra}' não está no dicionário.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Dicionário de sinônimos em ordem alfabética:");

                        foreach (var item in dicionarioSinonimos)
                        {
                            Console.WriteLine($"Sinônimos de '{item.Key}':");
                            for (int i = 0; i < item.Value.Count; i++)
                            {
                                Console.Write(item.Value[i] + " ");
                            }

                        }
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}