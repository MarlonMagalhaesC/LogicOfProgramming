

using System.Reflection;

class Program
{
    static void Main()
    {

        int n, x, cont = 0;

        Console.WriteLine("Digite n: ");
        n = int.Parse(Console.ReadLine());

        int[] V = new int[n];

        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento do vetor: ");
            V[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Digite x: ");
        x = int.Parse(Console.ReadLine());

        for (int i = 0; i < V.Length; i++)
        {
            if (x == V[i])
                cont++;
        }

        if (cont > 0 )
        Console.WriteLine($"{x} aparece no vetor: ");

        else 
        Console.WriteLine($" {x} nao aparece no vetor: ");





        //

    }
}
