using System;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um numero inteiro n:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Soma n primeiros positivos:");
        Console.WriteLine(CalculaSomaNpri(n));

        Console.WriteLine("Soma n primeiros positivos pares:");
        Console.WriteLine(CalculaSomaNpriPares(n));

        Console.WriteLine("Soma n primeiros positivos impares:");
        Console.WriteLine(CalculaSomaNpriImpares(n));
    }

    static int CalculaSomaNpri(int n)
    {
        int i, soma = 0;

        for (i = 1; i <= n; i++)
        {

            soma += i;
        }
        return (soma);
    }

    static int CalculaSomaNpriPares(int n)
    {
        int i, soma = 0;

        for (i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 0)
                soma += i;
        }
        return (soma);
    }

    static int CalculaSomaNpriImpares(int n)
    {
        int i, soma = 0;

        for (i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 1)
                soma += i;
        }
        return (soma);
    }

}