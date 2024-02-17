

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite n: ");
        n = int.Parse(Console.ReadLine());

        MostraN(n);

    }


    static int [] CalculaPosicao(int n)
    {
        int[] V = new int[n];

        for (int i = 0; i < V.Length; i++)
        {
            V[i] = (i + 1) * 2;
        }
        return V;
    }

    static void MostraN(int n)
    {

        int [] V = CalculaPosicao(n);

        for (int i = 0; i < V.Length; i++)
        {

            Console.WriteLine(V[i]);
        }


    }

}







