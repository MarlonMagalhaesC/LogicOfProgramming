using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n, cont = 0, contprimos = 0;

        Console.WriteLine("Digite um numero inteiro: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)

                    cont++;
            }

            if (cont == 2)
            {
                Console.WriteLine($"{i} e primo");
                contprimos++;
            }
            cont = 0;
        }

        Console.WriteLine($" total de primos: {contprimos} ");













    }
}
