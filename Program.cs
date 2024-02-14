using System;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um numero inteiro n:");
        n = int.Parse(Console.ReadLine());

        NprimeirosPos(n);

        NprimeirosPares(n);

        NprimeirosImp(n);



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
        for (i=1; i<=n*2; i++)
        {
          if (i % 2 == 1)
                Console.WriteLine(i);
        }
    }
}