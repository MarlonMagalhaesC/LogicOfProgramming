using System;

class Program
{
    static void Main()
    {
        int q1, q2, cont = 0, cont2 = 0;


        Console.WriteLine("Digite o tamanho do vetor 1: ");
        q1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tamanho do vetor 2: ");
        q2 = int.Parse(Console.ReadLine());

        int[] V1 = new int[q1];
        int[] V2 = new int[q2];

        for (int i = 0; i < V1.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento do vetor 1: ");
            V1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < V2.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento do vetor 2: ");
            V2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < V1.Length; i++)
        {
            for (int j = 0; j < V2.Length; j++)
            {
                if (V1[i] % V2[j] == 0)
                    cont++;
            }

            if (cont == V2.Length)
            {
                Console.WriteLine($"{V1[i]}e multiplo de todos os elementos de V2: ");
                cont2++;
            }

            cont = 0;
        }

        if (cont2 == 0)
            Console.WriteLine("Nenhum elemento de V1 e multiplo de todos os elementos de V2");







    }
}
