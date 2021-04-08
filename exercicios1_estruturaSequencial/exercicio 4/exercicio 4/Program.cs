using System;
using System.Globalization;
namespace exercicio_4 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("---Fazer um programa que leia o número de um funcionário---");
            int numFuncionario, numhorasTrab;
            double valorHora , salario;

               numFuncionario = int.Parse(Console.ReadLine());
               numhorasTrab = int.Parse(Console.ReadLine());
              valorHora = double.Parse(Console.ReadLine());
            salario = valorHora * numhorasTrab;
            Console.WriteLine("O numero do funcionario é  " + numFuncionario);
            Console.WriteLine("valor do salario é " +salario.ToString("F2",CultureInfo.InvariantCulture ));

        }
    }
}
