using System;

namespace EXERCICIO1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine(" Entre com a altura do retangulo :");
            Retangulo r = new Retangulo();
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine(" Entre com a largura do retangulo :");
            r.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine(" Area do triangulo :"+r.Area());
            Console.WriteLine("Perimetro do triangulo "+r.Perimetro());
            Console.WriteLine(" Diagonal do triangulo "+r.Diagonal());

        }
    }
}
