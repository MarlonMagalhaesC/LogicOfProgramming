using System;

class Program
{
    static void Main()
    {

        int[] V = new int[10];



        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine($"Digite o elemento {i + 1}o: ");
            V[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Vetor: ");

        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine(V[i]);
        }
        Console.WriteLine($"");

        for (int i = 0; i < V.Length - 1; i++)

        {
            V[i] = V[i + 1];
        }

        V[V.Length - 1] = 0;

        

        Console.WriteLine($"Vetor modificado: ");
        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine(V[i]);
        }




















    }
}
