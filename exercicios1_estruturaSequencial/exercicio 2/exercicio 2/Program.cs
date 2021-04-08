using System;
using System.Globalization;
namespace exercicio_2 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Faça um programa para ler o valor do raio de um círculo ---- ");
            Console.WriteLine(" digite o valor do raio ");

            float raio, area, pi = 3.14159f;

            raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * raio * raio;


            Console.WriteLine(" o valor da area é :"+area );



        }
    }
}
