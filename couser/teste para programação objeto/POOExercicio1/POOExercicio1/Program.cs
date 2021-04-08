using System;

namespace POOExercicio1 {
    class Program {
        static void Main(string[] args)
        {
            pessoas p1 = new pessoas();
            pessoas p2 = new pessoas();

            Console.WriteLine("Insira o nome de uma pessoa  ");
            Console.WriteLine("Nome :");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Insira a idade da pessoa  ");
            Console.WriteLine("idade :");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" insira o nome de outra pessoa ");
            Console.WriteLine("Nome :");
            p2.nome = Console.ReadLine();


            Console.WriteLine("Insira a idade de outra pessoa  ");
            Console.WriteLine("idade :");
            p2.idade = int.Parse(Console.ReadLine());


            if (p1.idade>p2.idade) {
                Console.WriteLine( "pessoa mais velha :" +p1.nome);
            }
            else{
                Console.WriteLine(" pessoa mais velha :" +p2.nome);
            }
        }
    }
}
