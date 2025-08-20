using System;
using System.Runtime.InteropServices;

namespace exercicio03
{
    internal class Program
    {
        //Struct
        public struct CadastrarHeroi
        {
            public string Nome;
            public string Poder;
            public int Pontuacao;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("Exercicio03_Aula08");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.White;

            //Crie uma função chamada cadastrarHeroi que permita ao usuário inserir o nome, poder e pontuação de um herói da Marvel. 
            //A função deve solicitar essas informações ao usuário e armazená-las em UM STRUCT.
            //O programa deve permitir o cadastro de até 5 heróis.

            Console.WriteLine("Entre as informacoes do seu heroi");
        }
    }
}