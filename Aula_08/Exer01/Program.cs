//Defina uma struct Produto que contenha
//os seguintes campos: Nome, Codigo,
//Preco e Quantidade. Crie um programa
//que permita ao usuário inserir dados de 3
//produtos e, em seguida, exiba o valor
//total em estoque (considerando o preço e
//a quantidade de cada produto).

using System;
using System.Runtime.InteropServices;

namespace exercicio04
{
    internal class Program
    {

        public struct Produto{
            public string Nome;
            public int Codigo;
            public double Preco;
            public int Quantidade;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio02_Aula05");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.White;

            Produto.a1;
            Produto.a2;
            Produto.a3;


            Console.WriteLine("Entre com o nome do produto 1: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o códido do produto 1: ");
            a1.Codigo = Console.ReadLine;

            Console.WriteLine("Entre com o preço do produto 1: ");
            a1.Preco = Console.ReadLine;

            Console.WriteLine("Entre com a quantidade do produto 1: ");
            a1.Quantidade = Console.ReadLine;


            Console.WriteLine("Entre com o nome do produto 2: ");
            a2.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o códido do produto 2: ");
            a2.Codigo = Console.ReadLine;

            Console.WriteLine("Entre com o preço do produto 2: ");
            a2.Preco = Console.ReadLine;

            Console.WriteLine("Entre com a quantidade do produto 2: ");
            a2.Quantidade = Console.ReadLine;


            Console.WriteLine("Entre com o nome do produto 3: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o códido do produto 3: ");
            a1.Codigo = Console.ReadLine;

            Console.WriteLine("Entre com o preço do produto 3: ");
            a1.Preco = Console.ReadLine;

            Console.WriteLine("Entre com a quantidade do produto 3: ");
            a1.Quantidade = Console.ReadLine;

            int somaA1 = a1.Quantidade * a1.Preco;
            int somaA2 = a2.Quantidade * a2.Preco;
            int somaA1 = a3.Quantidade * a3.Preco;

            Console.WriteLine($"Você tem em estoque do produto 1: {a1.Quantidade}, cada um custa: {a1.Preco} reais, ao todo você tem: {somaA1} reais.");
            Console.WriteLine($"Você tem em estoque do produto 2: {a2.Quantidade}, cada um custa: {a2.Preco} reais, ao todo você tem: {somaA2} reais.");
            Console.WriteLine($"Você tem em estoque do produto 3: {a3.Quantidade}, cada um custa: {a3.Preco} reais, ao todo você tem: {somaA3} reais.");
            
        }
    }
}

