using System;

namespace exercicio_3 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("------Programa para calcular se os numeros digitados sao  multiplos------ " );
            Console.WriteLine("digite um numero :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Sao multiplos ");

            }
            else {
                Console.WriteLine(" Nao sao multiplos");

            }

        }
    }
}
