using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número:");

           int primeironumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o operador:");


            Console.WriteLine("Insira um número:");

            int segundonumero = int.Parse(Console.ReadLine());

            int soma = (primeironumero + segundonumero);

            Console.WriteLine($"O resultado da soma é:{soma}");



        }
    }
}
