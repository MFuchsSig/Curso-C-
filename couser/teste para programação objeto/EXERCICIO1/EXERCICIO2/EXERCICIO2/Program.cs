using System;

namespace EXERCICIO2 {
    class Program {
        static void Main(string[] args)
        {

            Funcionario F = new Funcionario();
            Console.WriteLine("Digite o nome do fúncionario");
            F.Nome = Console.ReadLine();

            Funcionario SB = new Funcionario();
            Console.WriteLine(" Digite o salario Bruto ");
            SB.SalarioBruto = double.Parse(Console.ReadLine());


            Funcionario I = new Funcionario();
            Console.WriteLine(" Digite o imposto");
            I.Imposto = double.Parse(Console.ReadLine());


        }
    }
}
