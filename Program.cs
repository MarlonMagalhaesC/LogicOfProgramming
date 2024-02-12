using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n, x, cont = 0;

        Console.WriteLine("Digite um número: ");
        n = int.Parse(Console.ReadLine());

        int[] V = new int[n];

        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1} elemento do vetor: ");
            V[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite um número: ");
        x = int.Parse(Console.ReadLine());


        for (int i = 0; i < V.Length; i++)
        {
            if (x == V[i])
            {
                cont++;
            }
        }

        if (cont > 0)
                Console.WriteLine($"{x} esta entre os numeros armazenados {cont} vez(es)!");

       else
            Console.WriteLine($"{x} NAO esta entre os numeros armazenados.");





    }
}
