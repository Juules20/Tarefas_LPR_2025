using System;
using System.Runtime.InteropServices;

namespace exercicio04{
    internal class Program{
        static void Main(string[]args){

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio04_Aula05");
            Console.WriteLine("========================================");

            int soma = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite um numero:");
            int num = int.Parse(Console.ReadLine());

            int quadrado = num * num ;
            
            while(quadrado > 0){
                soma += quadrado %10;
                quadrado /= 10;
            }
            Console.WriteLine($"A soma dos digitos e: {soma}");
        }
    }
}
