using System;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um valor inteiro positivo n:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Inteiros positivos: ");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Inteiros positivos Pares: ");

        for (int i = 2; i <= n * 2; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }


        
        Console.WriteLine("Inteiros positivos Impares: ");

        for (int i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine(i);
        }
    }
}
