using System;

namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano = 365;
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos anos você tem?");
            int anos = int.Parse(Console.ReadLine());
            Console.WriteLine(nome + ", você já viveu por " + anos * ano + " dias! :D");
        }
    }
}