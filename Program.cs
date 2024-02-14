using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um numero n:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Total de divisores do numero {n}:\n {RetornaNDivPositivos(n)}");

        EscreveNDivPositivos(n);

    }

    static void EscreveNDivPositivos(int n)
    {
        int i;

        Console.WriteLine($"O divisores positivos de {n} sao: ");

        for (i = 1; i <= n; i++)
        {
            if (n % i == 0)
               Console.WriteLine(i);
        }
       
    }






    static int RetornaNDivPositivos(int n)
    {
        int i, cont = 0;

        for (i = 1; i <= n; i++)
        {
            if (n % i == 0)
                cont++;
        }
        return (cont);
    }







}


