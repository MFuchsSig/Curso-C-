using System;
using System.Globalization;
namespace exercicio_3 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para ler quatro valores inteiros A, B, C e D");
            int A, B, C, D , diferenca;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca =A * B - C * D;

            Console.WriteLine(" A diferença é" + diferenca);

             

        }
    }
}
