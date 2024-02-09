

using System.Reflection;

class Program
{
    static void Main()
    {

        int n, omaior = int.MinValue;

        Console.WriteLine("Digite um numero inteiro n: ");
        n = int.Parse(Console.ReadLine());

        int[] V = new int[n];

        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento do vetor: ");
            V[i] = int.Parse(Console.ReadLine());

            if (V[i] > omaior)
                omaior = V[i];

        }

        Console.WriteLine($"{omaior} e maior do vetor: ");


        //

    }
}
