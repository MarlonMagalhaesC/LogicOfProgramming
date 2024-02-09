

using System.Reflection;

class Program
{
    static void Main()
    {
       int n, x, cont = 0;

        Console.WriteLine("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] V = new int[n];

        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine($"Digite o {i+1}o elemento do Vetor: ");
            V[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite um numero inteiro: ");
        x = int.Parse(Console.ReadLine());

        for (int i = 0; i < V.Length; i++)
        {
            if (x == V[i])
                cont++;
        }

        Console.WriteLine($"{x} apareceu no vetor {cont} vezes");






//

    }
}
