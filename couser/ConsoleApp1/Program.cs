﻿using System;
using System.Globalization;
namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("----- Produtos -----");
            Console.WriteLine(produto1 + " Cujo o preço é $" + preco1.ToString("F2"));
            Console.WriteLine(produto2 + " Cujo o preço é $" + preco2.ToString("F2"));
            Console.WriteLine("----Registro ----");
            Console.WriteLine(idade + " anos de idade, " + "Seu codigo de registro é " + codigo + " e gênero : " + genero);
            Console.WriteLine("Medida com oito casas decimais :" + medida.ToString(" F8"));
            Console.WriteLine("Arredondado(Três casas decimais :)" + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture:" +medida.ToString(" F3",CultureInfo.InvariantCulture));
        }
    }
}
