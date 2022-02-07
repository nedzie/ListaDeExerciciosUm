using System;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vPao = 0.12, vBroas = 1.50, tPao = 0, tBroas = 0, total = 0, descTotal = 0, vFinal = 0;

            Console.WriteLine("-= Leitura Z - Hotpão =-\nQuantos pães vendemos hoje?");
            double pao = double.Parse(Console.ReadLine());
            //Console.WriteLine(pao);
            tPao = pao * vPao;
            //Console.WriteLine(pao);

            Console.WriteLine("E quantas broas?");
            double broas = double.Parse(Console.ReadLine());
            //Console.WriteLine(broas);
            tBroas = broas * vBroas;
            //Console.WriteLine(broas);

            total = pao + broas;
            descTotal = total * 0.10;
            vFinal = total - descTotal;

            Console.Clear();
            Console.WriteLine("Relatório final:");
            Console.WriteLine("Pães vendidos............: " + pao + " un");
            Console.WriteLine("Venda dos pães...........: R$" + pao);
            Console.WriteLine("\nBroas vendidas...........: " + broas + " un");
            Console.WriteLine("Venda das broas..........: R$" + broas);
            Console.WriteLine("\nTotal....................: R$" + total);
            Console.WriteLine("Valor depósito poupança..: R$" + descTotal);
            Console.WriteLine("Valor final caixa........: R$" + vFinal);



            Console.ReadLine();
        }
    }
}