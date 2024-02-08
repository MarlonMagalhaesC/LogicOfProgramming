using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n, fatorial = 1;

        Console.WriteLine("Digite um numero: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;

        }
        Console.WriteLine($"O fatorial de {n} sera de {fatorial}");



    }
}
