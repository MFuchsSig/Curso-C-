using System;
using System.Globalization;
namespace exercicio_2 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("------exercício de fixação-------");
            Console.WriteLine(" Entre com seu nome completo ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine(" Quantos quartos tem na sua casa ?");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine(" Entre com o preço de um produto");
            float preçoProdt = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(" Entre com seu ultimo nome , idade e altura (mesma linha) : ");
            string[] vect = Console.ReadLine().Split(' ');
            string ultimoNome = vect[0];
            int idade = int.Parse(vect[1]);
            float altura = float.Parse(vect[2],CultureInfo.InvariantCulture);

            Console.WriteLine("-----Dados Do Cadastrado-----");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preçoProdt.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
