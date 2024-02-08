using System;

class Program
{
    static void Main()
    {
        int n, i;

        Console.WriteLine("Números inteiros de 0 a 50: ");

        for (i = 0; i <= 50; i++)
        {
            Console.Write($"{i}-");
        }
        Console.WriteLine();

        Console.WriteLine("Números inteiros pares de 0 a 50: ");

        for (i = 0; i <= 50; i++)
        {
            if (i % 2 == 0)
                Console.Write($"{i}-");
        }
        Console.WriteLine();

         Console.WriteLine("Números inteiros múltiplos de 3 de 1 a 50:");
          for (i = 1; i <= 50; i++)
        {
            if (i % 3 == 0)
                Console.Write($"{i}-");
        }
        Console.WriteLine();

          Console.WriteLine("Números inteiros pares e múltiplos de 3 de 0 a 50:");
          for (i = 1; i <= 50; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
                Console.Write($"{i}-");
        }

        Console.WriteLine();

          Console.WriteLine("Números inteiros de 100 a 1 (em ordem decrescente):");
          for (i = 100; i >= 1; i--)
        {
                Console.Write($"{i}-");
        }
        Console.WriteLine();

        Console.WriteLine("Quadrado dos números inteiros no intervalo fechado de 1 a 20:");

          for (i = 1; i <= 20; i++)
        {
            
                Console.Write($"{Math.Pow(i,2)}-");
        }

        





    }
}
