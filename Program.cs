using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n, flag;
        
        Console.WriteLine("Digite um numero n:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a flag:");
        flag = int.Parse(Console.ReadLine());

        Decisao(n, flag);


    }

    static void Decisao(int n, int flag)
    {
        if (flag == 1)
            NprimeirosPos(n);

        else if (flag == 2)
            NprimeirosPares(n);

        else if (flag == 3)
            NprimeirosImp(n);

        else if (flag == 4)
            Console.WriteLine(CalculaSomaNpri(n));

        else if (flag == 5)
            Console.WriteLine(CalculaSomaNpriPares(n));

        else if (flag == 6)
            Console.WriteLine(CalculaSomaNpriImpares(n));

        else
            Console.WriteLine("Digite a flag correta.");
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

    static void NprimeirosPos(int n)
    {
        int i;

        Console.WriteLine("Os n primeiros positivos:");

        for (i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void NprimeirosPares(int n)
    {
        int i;

        Console.WriteLine("Os n primeiros positivos Pares:");

        for (i = 2; i <= n * 2; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }


    static void NprimeirosImp(int n)
    {
        int i;

        Console.WriteLine("Os n primeiros positivos Impares:");
        for (i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine(i);
        }
    }
}


