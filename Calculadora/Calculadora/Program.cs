using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int idade = 0;
            //string Name = "Fernando Mendes";
            //DateTime dataNascimento = DateTime.Parse("15/01/1986");
            //double salario = 1000.00;
            //decimal salario2 = 1000;
            //float salario3 = 100;
            //bool condicao = false;
            //Guid guid = Guid.Parse("Mendes");
            //int conversao = int.Parse("20");


            //Console.WriteLine("Digite o primeiro número");
            //int primeiroNumero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo número");
            //int segundoNumero = int.Parse(Console.ReadLine());

            //int soma = Somar(primeiroNumero, segundoNumero);

            //if (soma > 90)
            //{
            //    soma = (soma + 10);
            //}
            //else
            //{
            //    soma = (soma - 10);
            //}

            //Console.WriteLine($"A Soma é de: {soma}");

            //Console.WriteLine("Digite o primeiro número");
            //int primeiroNumero = int.Parse(Console.ReadLine());

            //while(primeiroNumero > 0)
            //{
            //    primeiroNumero = primeiroNumero - 1;
            //    Console.WriteLine($"Valor {primeiroNumero}");
            //}

            string[] listaPaises = { "Itália", "Brasil", "EUA", "Mexico", "Japão" };

            for (int index = 0; index < listaPaises.Length; index++)
            {
                Console.WriteLine($"Pais {listaPaises[index]}");
            }

            //while (index >= 0)
            //{
            //    primeiroNumero = primeiroNumero - 1;
            //    Console.WriteLine($"Valor {primeiroNumero}");
            //}


            //do
            //{
            //    primeiroNumero = primeiroNumero - 1;
            //}
            //while (primeiroNumero > 0);


            Console.ReadKey();
        }

        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
}
