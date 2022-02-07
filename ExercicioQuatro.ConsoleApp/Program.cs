using System;

namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q.G.S.S.F.E.F.\nQuantos graus (ºC) está agora?");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.Clear();
            Console.WriteLine(celsius + "°C, convertido fica " + fahrenheit + "°F");
        }
    }
}