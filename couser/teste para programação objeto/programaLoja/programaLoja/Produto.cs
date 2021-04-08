using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace programaLoja {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        
            
        public override string ToString()
        {
            return Nome
                + " , $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " ,"
                + Quantidade
                + " unidades , Total : $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int quantidade)
        {
            quantidade +=quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            quantidade -= quantidade;
        }
    }
}