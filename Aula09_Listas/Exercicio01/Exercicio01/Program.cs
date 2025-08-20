using System;
using System.Diagnostics.CodeAnalysis;
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

            //Construa uma lista de X nomes aleatórios
            //A saída deve ser mostrada em uma ou mais linhas. 
            //Cada linha tem uma lista de nomes ordenados por tamanho, começando com o menor. 
            //Em cada linha, só pode ser mostrado um nome de determinado tamanho, e os demais nomes com o mesmo tamanho devem ser
            //apresentados nas linhas seguintes. Você deve seguir a ordem de digitação

            List<string> nomes = new List<string> { "Bianca", "Rafael", "Julia", "Larisa", "Camila" };

            foreach (string nome in nomes)
            {
                
            }
        }
    }
}