﻿using System;

namespace exercicio1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine( "digite um numero " );
            int numero = int.Parse(Console.ReadLine());

            if (numero< 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }

}