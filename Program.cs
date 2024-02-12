using System;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um número: ");
        n = int.Parse(Console.ReadLine());

        int[] I = new int[n];
        int[] P = new int[n];


        int valorImpar = 1;
        int valorPar = 2;


        for (int i = 0; i < n; i++)
        {
            I[i] = valorImpar;
            P[i] = valorPar;

            valorImpar += 2;
            valorPar += 2;

        }
        Console.WriteLine("Ímpares:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(I[i]);
        }

        Console.WriteLine("Pares:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(P[i]);
        }


        
    }
}
