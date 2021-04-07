using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = { "L", "a", "r", "i", "s", "s", "a" };

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
            Console.ReadKey();
        }
    }
}
