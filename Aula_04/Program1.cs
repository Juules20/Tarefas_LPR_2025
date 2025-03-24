using System;

namespace exercicio01{
    internal class Program{
        static void Main(string[]args){

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio01_Aula04");
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Entre com um número inteiro e eu direi se é par ou ímpar:");
            int num = int.Parse(Console.ReadLine());

            if(num%2 == 0){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O número fornecido é par");
            }else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O número digitado é ímpar");
            }
        }
    }
}