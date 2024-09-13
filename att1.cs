using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection2
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> lista = new List<int>();


                int opcaoo = 0;

                while (opcaoo != 9)
                {
                    Console.Clear();
                    Console.WriteLine("1 - Insira um número na lista");
                    Console.WriteLine("2 - Verificar se um número se encontra na lista");
                    Console.WriteLine("3 - Exiba a soma de todos os números na lista");
                    Console.WriteLine("4 - Exiba o maior número na lista");
                    Console.WriteLine("5 - Exiba o menor número na lista");
                    Console.WriteLine("6 - Remova todos os números pares da lista");
                    Console.WriteLine("7 - Exiba os números que estão na lista, após a remoção dos números pares");
                    Console.WriteLine("8 - Inverta os elementos da lista");
                    Console.WriteLine("9 - Encerrar o programa");

                    Console.Write("Escolha uma opção:");
                    opcaoo = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcaoo)
                    {
                        case 1:Console.Write("Digite um numero:");
                        int n = int.Parse(Console.ReadLine());
                        Inserir(n, lista);
                        Console.WriteLine("Numero Inserido:" + n);
                        break;
                        
                        case 2:Console.Write("Escolha um numero para verificar se esta na lista:");
                        n = int.Parse(Console.ReadLine());
                        if (VerificarSeEstaNaLista(n, lista))
                            Console.WriteLine("O numero existe na lista");
                        else
                            Console.WriteLine("O numero não existe na lista");
                        break;
                        case 3:Console.WriteLine($"A soma total dos numeros na lista e:{Soma(lista)}");
                  
                            break;
                    case 4:
                        Console.WriteLine($"O maior valor da lista e:{Maior(lista)}");

                        break;
                        case 5:
                        Console.WriteLine($"O menoe valor da lista e:{Menor(lista)}");

                        break;
                        case 6:Console.WriteLine("Numeros pares retirados");
                        DeletarPar(lista);
                         
                            break;

                        case 7:Console.WriteLine("Lista com os pares removidos:");
                        ExibirRemovPar(lista);
                            break;
                    case 8:Console.WriteLine("Lisa invertida");
                        Inverter(lista);
                        break;
                        case 9:
                            Console.WriteLine("FIM");
                            break;
                    default: Console.WriteLine("Opção infalida");
                        break;

                }

                Console.ReadLine();
                }


                Console.ReadLine();


            }

        static void Inserir(int n,List<int> L)
        {
            L.Add(n);

        }
        static bool VerificarSeEstaNaLista(int n,List<int> L)
        {
            if (L.Contains(n))
                return true;
            else
                return false;
        }
        static int Soma(List<int> L)
        {
            int total = 0;

            foreach(int nun in L)
            {
                total += nun;
            }

            return total;

        }
        static int Maior(List<int> L)
        {
            return L.Max();
        }
        static int Menor(List<int> L)
        {
            return L.Min();
        }
        static void DeletarPar(List<int> L)
        {
            for(int i = 1; i<L.Count();i++)
            {
                if (L[i] % i == 0)
                    L.Remove(i);
            }
              



        }    
        static void ExibirRemovPar(List<int> L)
        {
            DeletarPar(L);
            foreach(int n in L)
            {
                    Console.Write(n + " ");
            }
        }
        static void Inverter(List<int> L)
        {
            L.Reverse();
        }



        }
    }
