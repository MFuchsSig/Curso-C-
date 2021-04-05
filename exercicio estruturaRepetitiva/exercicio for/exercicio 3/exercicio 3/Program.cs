using System;

namespace exercicio_3 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("----Programa pra calcular os divisores de um numero----");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
