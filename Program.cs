using System;
using System.Collections.Generic;

namespace listaObj_23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            List<Cartao> cartao = new List<Cartao>();

            produtos.Add(new Produto(0,"Pocophone", 1550.88f) );
            produtos.Add(new Produto(1,"Iphone 11", 8550.88f) );
            produtos.Add(new Produto(2,"Galaxy A 71", 2550.88f) );
            produtos.Add(new Produto(3,"Zenfone 7", 9550.88f) );
            foreach(Produto p in produtos)
            {
                System.Console.WriteLine($"Celular: {p.nome} - {p.preco}");
            }

            System.Console.WriteLine();

            cartao.Add(new Cartao("Gabriel Carvalho", 54999046789, "08/27", 872));
            cartao.Add(new Cartao("Isabella Marinho", 55783428901, "05/26", 872));
            cartao.Add(new Cartao("João Macedo", 44789201021, "01/29", 872));

            // Lista com laço forreach
            foreach(Cartao a in cartao)
            {
                System.Console.WriteLine($"Cartão: {a.Titular} - {a.Numero} - {a.Vencimento} - {a.Cvv}");
            }
            // Removendo através de indice
            cartao.RemoveAt(2);

            // removendo através de lambda
            cartao.RemoveAll(a => a.Titular == "Gabriel Carvalho");
            
        }
    }
}
