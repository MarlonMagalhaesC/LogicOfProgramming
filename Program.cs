using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int q1, q2, cont = 0, omaior=int.MinValue;

        Console.WriteLine("Digite q1: ");
        q1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite q2: ");
        q2 = int.Parse(Console.ReadLine());


        int[] V1 = new int[q1];
        int[] V2 = new int[q2];

        for (int i = 0; i < V1.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento: ");
            V1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < V2.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento: ");
            V2[i] = int.Parse(Console.ReadLine());

            if (V2[i] > omaior)
            {
              omaior = V2[i];
            }
        }

        Console.WriteLine(omaior);

        for (int i = 0; i < V1.Length; i++)
        {
           if (V1[i]> omaior)
           Console.WriteLine($"O {V1[i]} e maior que todos os elementos de V2");
           
        }








    }
}
