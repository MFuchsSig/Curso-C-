using System;
using System.Globalization;
namespace exercicios1_estruturaSequencial {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("----Faça um programa para ler dois valores inteiros----");
            int a;
            int b;
            int soma;
            Console.WriteLine(" Digite o primeiro número :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o segundo número :");
            b = int.Parse(Console.ReadLine());
            soma = a + b;
            Console.WriteLine(" A soma dos números é " +soma );
        }
    }

  
}
