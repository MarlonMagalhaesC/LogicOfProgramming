using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int i, j, n;

        Console.WriteLine("Digite um numero n:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero i:");
        i = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite j:");
        j = int.Parse(Console.ReadLine());

        Console.WriteLine(ValidarEntreIeJ(i,j,n));

    }

    static bool ValidarEntreIeJ (int i, int j, int n)
    {
         return n >= i && n <= j;
    }



}


