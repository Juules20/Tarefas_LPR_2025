using System;
using System.Runtime.InteropServices;

namespace exercicio01
{
    internal class Program
    {

        public struct Produto
        {
            public string Nome;
            public int Codigo;
            public double Preco;
            public int Quantidade;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio01_Aula08");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.White;

            Produto a1, a2, a3;


            Console.WriteLine("Entre com o nome do produto 1: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o códido do produto 1: ");
            a1.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto 1: ");
            a1.Preco = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade do produto 1: ");
            a1.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o nome do produto 2: ");
            a2.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o códido do produto 2: ");
            a2.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto 2: ");
            a2.Preco = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade do produto 2: ");
            a2.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o nome do produto 3: ");
            a3.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o códido do produto 3: ");
            a3.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto 3: ");
            a3.Preco = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade do produto 3: ");
            a3.Quantidade = int.Parse(Console.ReadLine());

            double somaA1 = a1.Quantidade * a1.Preco;
            double somaA2 = a2.Quantidade * a2.Preco;
            double somaA3 = a3.Quantidade * a3.Preco;

            Console.WriteLine($"Você tem em estoque do produto 1: {a1.Quantidade} {a1.Nome}, cada um custa: {a1.Preco} reais, ao todo você tem: {somaA1} reais.");
            Console.WriteLine($"Você tem em estoque do produto 2: {a2.Quantidade} {a2.Nome}, cada um custa: {a2.Preco} reais, ao todo você tem: {somaA2} reais.");
            Console.WriteLine($"Você tem em estoque do produto 3: {a3.Quantidade} {a3.Nome}, cada um custa: {a3.Preco} reais, ao todo você tem: {somaA3} reais.");

        }
    }
}