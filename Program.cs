

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite n: ");
        n = int.Parse(Console.ReadLine());

        MostraN(n);




    }

    static void MostraN(int n)
    {
        Console.Write($"Os {n} primeiros numeros impares: ");
        int[] V = Impar(n);

        for (int i = 0; i < V.Length; i++)
        {
            Console.WriteLine(V[i]);
        }

    }

    static int[] Impar(int n)
    {
        int i;
        int[] V = new int[n];

        for (i = 1; i <= n; i++)
        {
            V[i - 1] = (i * 2) - 1;
        }

        return V;

    }



}







