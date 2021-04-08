using System;

namespace exercicio_4 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine(" Defina quanto tempo durou o jogo");
            int horaInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
