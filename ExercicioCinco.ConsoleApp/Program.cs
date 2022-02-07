using System;

namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salário?");
            double salario = double.Parse(Console.ReadLine());
            double aumento = salario * 1.15;
            double imposto = aumento * 0.92;
            Console.WriteLine("Folha de pagamento:");
            Console.WriteLine($"Salário base...........: R$ {salario:F2}");
            Console.WriteLine($"Salário com aumento....: R$ {aumento:F2}");
            Console.WriteLine($"Salário com desconto...: R$ {imposto:F2}");
            Console.ReadLine();
        }
    }
}