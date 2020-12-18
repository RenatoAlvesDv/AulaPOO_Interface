using System;
using AulaPOO_Interface.Classes;

namespace AulaPOO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           Carrinho carrinho = new Carrinho(); 

            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "Playstation 5";
            p1.Preco = 10000;


            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Nome = "Xbox Series X";
            p2.Preco = 50000;


            Produto p3 = new Produto();
            p3.Codigo = 1254;
            p3.Nome = "Nitendo Swicth";
            p3.Preco = 4000;



            carrinho.Cadastar(p1);
            carrinho.Listar();
            carrinho.Cadastar(p2);

            Console.ForegroundColor =ConsoleColor.Blue;

            carrinho.Alterar(p1.Codigo , p3);
            carrinho.Listar();

            Console.ResetColor();









        }     
    }
}
