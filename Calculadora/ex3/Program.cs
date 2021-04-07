using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um  numero");
            var numero = int.Parse(Console.ReadLine());

            int divisao = numero % 2;

            if( divisao == 0)
            { 
                Console.WriteLine("Este numero e par"); 
            }
            else
            {
                Console.WriteLine("Este numero e impar");
            }
            Console.ReadKey();
            

        }
    }
}
