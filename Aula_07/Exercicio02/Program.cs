using System;
using System.Runtime.InteropServices;

namespace exercicio02_Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio02_Aula07");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.White;
            
            int[] numeros = new int[10];
            int contador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Entre com o {i + 1}o valor");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Você gostaria de visualizar qual número no vetor?");
            int visualizar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == visualizar)
                {
                    Console.WriteLine($"Seu número se encontra na posição: {i}");
                    contador++;
                }
            }

            Console.WriteLine($"Seu número aparece {contador} vezes");
        }
    }
}