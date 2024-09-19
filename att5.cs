using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Dictionary<int, int> frequencia = new Dictionary<int, int>();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(random.Next(100));
            }

            Console.WriteLine("lista:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            foreach (int numero in numeros)
            {
                if (frequencia.ContainsKey(numero))
                {
                    frequencia[numero]++;
                }
                else
                {
                    frequencia[numero] = 1;
                }
            }

            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Verificar se um número consta no dicionário");
                Console.WriteLine("2 - Consultar quantos números distintos constam no dicionário");
                Console.WriteLine("3 - Imprimir todos os números e suas frequências de ocorrências");
                Console.WriteLine("4 - Encerrar o programa");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o número que deseja verificar: ");
                        int numero = int.Parse(Console.ReadLine());
                        VerificarNumero(numero, frequencia);
                        break;
                    case 2:
                        Console.WriteLine($"Há {frequencia.Count} números distintos no dicionário.");
                        break;
                    case 3:
                        ImprimirFrequencias(frequencia);
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


       
        static void VerificarNumero(int numero, Dictionary<int, int> frequencia)
        {
            if (frequencia.ContainsKey(numero))
            {
                Console.WriteLine($"O número {numero} está no dicionário e aparece {frequencia[numero]} vezes.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não está no dicionário.");
            }
        }


        static void ImprimirFrequencias(Dictionary<int, int> frequencia)
        {
            Console.WriteLine("Números e suas frequências:");

            foreach (var item in frequencia)
            {
                Console.WriteLine($"Número: {item.Key}, Frequência: {item.Value}");
            }
        }
    }
}