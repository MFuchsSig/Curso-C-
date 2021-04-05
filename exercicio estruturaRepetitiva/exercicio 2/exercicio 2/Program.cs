using System;

namespace exercicio_2 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qual o combustivel voce quer abastecer para finalizar o programa digite 4!");
            int combustivel = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int disel = 0;

            while (combustivel!=4) {
                if (combustivel == 1) {
                    alcool++;
                }
                else if (combustivel == 2) {
                    gasolina++;

                }   
                else if (combustivel == 3) {
                    disel++;
                }

                combustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Alcool: " + alcool++);
            Console.WriteLine("Gasolina :" + gasolina++);
            Console.WriteLine("Disel : " + disel++);

        }
    }
}
