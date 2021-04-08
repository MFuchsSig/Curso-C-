using System;
using System.Globalization;
namespace programaLoja {
    class Program {
        static void Main(string[] args)
        {

            Console.WriteLine("------------Programa para calcular estoque------------\r\n");
            Console.WriteLine(" Entre com os dados do produto :\r\n");
            Console.Write(" Nome : ");
            String nome = Console.ReadLine();
            Console.Write(" Preço : ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write(" Quantidade no estoque  ");
            int quantidade = int.Parse(Console.ReadLine());


            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine(" Dados do produto " +p +"\r\n");
            Console.Write(" Digite o número de produtos a ser adicionado ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);


            Console.WriteLine(" Dados atualizados "+p);
            Console.Write(" Digite o número de produtos a ser removidos ao estoque");
             qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine(" Dados atualizados " + p);
        }
    }
}
