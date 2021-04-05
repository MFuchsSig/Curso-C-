using System;

namespace exercicio_2 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("----Programa para mostrar números no intervalo de 10 a 20 -----");
            Console.WriteLine("           ");
            Console.WriteLine("Digite um número :");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++) 
            {
                string a = Console.ReadLine();
                int x = int.Parse(a);
                if (x >= 10 && x <= 20) {
                    dentro=dentro+1;
                }
                else {
                    fora++;
                }

            }

            Console.WriteLine(" in :" + dentro);
            Console.WriteLine(" out : " + fora++);
        }
    }
}
