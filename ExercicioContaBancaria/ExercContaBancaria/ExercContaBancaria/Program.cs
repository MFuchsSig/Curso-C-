using System;
using System.Globalization;
namespace ExercContaBancaria {
    class Program {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write(" Entre com o numero da conta :");
            int numero = int.Parse(Console.ReadLine());
            Console.Write(" Entre com o titular da conta : ");
            string titular = Console.ReadLine();
            Console.Write(" haverá deposito inicia (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp =='s' || resp =='S') {
                Console.Write(" Entre com o valor de deposito ");
                double depositoInicial = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);

            }

            Console.WriteLine();
            Console.WriteLine(" Dados da conta :");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Entre com um valor para depósito");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine(" Dados atualizados :");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque ");
           
            conta.Deposito(quantia);
            Console.WriteLine(" Dados atualizados :");
            Console.WriteLine(conta);
        }
    }
}
