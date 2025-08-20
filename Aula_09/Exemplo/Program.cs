using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exemplo_Aula09");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.White;

            //8. Remover todos os números 4

            List<int> num = new List<int> { 1, 2, 3, 4, 5 };
            int contador = 0;
            int repete = 0;

            num.Add(4);
            num.Insert(3, 7);
            num.Remove(2);

            bool contemOito = num.Contains(8);
            Console.WriteLine($"Sua lista contém número oito: {contemOito}");

            foreach (int numero in num)
            {
                if (numero > 4)
                {
                    contador++;
                }

                if (numero == 3)
                {
                    repete++;
                }
            }

            Console.WriteLine($"Tem {contador} números maiores que 4");
            Console.WriteLine($"O número 3 repete {repete} vezes");

            //foreach (int numero in num)
            //{
            //    Console.WriteLine(numero);
            //}
        }
    }
}