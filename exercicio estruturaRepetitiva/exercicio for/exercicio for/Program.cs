using System;

namespace exercicio_for {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine( "----Programa que mostra o numero impar----");
            Console.WriteLine("Digite um numero :");
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
