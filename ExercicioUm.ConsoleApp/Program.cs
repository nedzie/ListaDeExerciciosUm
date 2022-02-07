using System;

namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float comprimento, altura;
            Console.WriteLine("=========================================\nOlá,\nSeja bem-vindo(a) à Imobiliária Imóbilis.\n=========================================\n\nVamos calcular a área do seu terreno:");
            Console.WriteLine("Primeiro, digite a base [Comprimento], separando por ',' caso seja um número decimal: ");

            comprimento = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite a altura [Largura], também separando por ',' caso seja um número decimal: ");
            altura = float.Parse(Console.ReadLine());

            float area = comprimento * altura;
            Console.WriteLine("Certo, seu terreno de " + comprimento + "m, de comprimento e altura de " + altura + "m, tem uma área total de: " + area + "m².");
            Console.ReadLine();
        }
    }
}