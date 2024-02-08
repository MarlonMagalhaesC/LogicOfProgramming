using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n, i, numeros, soma = 0;
        float media;

        Console.WriteLine("Digite um numero n: ");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            Console.Write($"Digite o {i}o numero:");
            numeros = int.Parse(Console.ReadLine());

            soma += numeros;

        }

        media = (float)soma / n;

        Console.WriteLine($"A soma sera de: {soma}");
        Console.WriteLine($"A media sera de: {media}");




    }
}
