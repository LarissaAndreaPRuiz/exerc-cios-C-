using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
                int numero1 = 0;
                int numero2 = 0;
                int soma = 0;

            while (soma < 9876)
            {
                Console.WriteLine("Digite o primeiro numero");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                numero2 = int.Parse(Console.ReadLine());

                soma += numero1 + numero2 ;

                Console.WriteLine($"A soma é {soma}");
            }
                Console.WriteLine("Saiu do laço");
                Console.ReadKey();
        }
    }
}
