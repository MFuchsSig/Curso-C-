using System;

namespace exercicio_2 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero ");
            int x= int.Parse(Console.ReadLine());

            if ( x % 2 ==0 ) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Impar");
            }
        }
    }
}
