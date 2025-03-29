using System;

namespace exercicio02{
    internal class Program{
        static void Main(string[]args){

             Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio02_Aula05");
            Console.WriteLine("========================================");

            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1,100);
            int tentativas = 0;
            int num;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tente adivinhar o número de 1 a 100");

            do{
                Console.WriteLine("Digite o número:");
                num = int.Parse(Console.ReadLine());

                if ( num > valorInteiro && num < 101){
                    Console.WriteLine("Seu número é alto.");
                    Console.WriteLine("Tente novamente");
                    tentativas++;
                }else if( num < valorInteiro && num < 101){
                    Console.WriteLine("Seu número é baixo.");
                    Console.WriteLine("Tente novamente");
                    tentativas++;
                }else{
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acertou!!!");
                    Console.WriteLine($"Foram {tentativas} tentativas.");
                }
            }while(num != valorInteiro);
        }
    }
}