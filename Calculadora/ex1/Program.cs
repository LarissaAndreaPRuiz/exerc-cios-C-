using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero");
           var PriNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
           var SegNumero = int.Parse(Console.ReadLine());

           var soma = PriNumero + SegNumero;

            Console.WriteLine($"A soma dos numeros é igual a {soma}");

            for (int  index = 1; index <= 25; index ++)
            {
                soma = soma + 10;
                Console.WriteLine($"Repetição {index} e a soma é {soma}");
            }
            Console.WriteLine($"O resultado e igual {soma}");
            Console.ReadKey();
        }
    }
}
