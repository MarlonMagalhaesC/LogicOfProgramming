using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um numero inteiro positivo: ");
        n = int.Parse(Console.ReadLine());

          Console.WriteLine($"Os divisores positivos sao: ");

        for (int i=1; i<=n; i++)
        {
           if (n % i == 0)
           Console.WriteLine(i);

        }



    }
}
