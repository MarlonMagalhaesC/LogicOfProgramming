using System;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um valor inteiro positivo n:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Todos os pares ordenados entre (0,0) e (n,n): ");

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                Console.WriteLine($"({i},{j})");
            }
        }
    }
}
