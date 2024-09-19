using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma frase ou palavra que sera invertida");
            string texto = Console.ReadLine();

            Stack<char> Pilha = new Stack<char>();

            for(int i = 0; i < texto.Length; i++)
            {
                Pilha.Push(texto[i]);
            }

            Console.WriteLine("A string ao contrario e:");

            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(Pilha.Pop());
            }

            Console.ReadLine();





        }
    }
}
