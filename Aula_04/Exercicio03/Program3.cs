using System;

namespace exercicio03{
    internal class Program{
        static void Main(string[]args){

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio03_Aula04");
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Escolha sua classe entre guerreiro, mago, arqueiro ou clerigo:");
            string classe = Console.ReadLine();

            switch (classe){
                case "guerreiro":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A classe Gurreiro tem como habilidades: Ataque pesado e defesa total");
                break;

                case "mago":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A classe Mago tem como habilidades: Bola de fogo e escudo de gelo");
                break;

                case "arqueiro":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A classe Arqueiro tem como habilidades: Flecha precisa e disparo triplo");
                break;

                case "clerigo":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A classe Clerigo tem como habilidades: Cura em area e escudo para aliados");
                break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}