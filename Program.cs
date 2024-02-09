

class Program
{
    static void Main()
    {
        int n, aux = 2;

        Console.WriteLine("Digite um numero inteiro: ");
        n = int.Parse(Console.ReadLine());

        int[] VP = new int[n];

        for (int i = 0; i < VP.Length;)
        {

            if (primo(aux) == true)
            {
                VP[i] = aux;
                i++;
            }

            aux++;
        }

        Console.WriteLine("Vetor: ");
        for (int i = 0; i < VP.Length; i++)
        {
            Console.WriteLine(VP[i]);

        }



        //

    }

    static int divisores(int n)
    {
        int i, cont = 0;
        for (i = 1; i <= n; i++)
            if (n % i == 0)
                cont++;
        return (cont);
    }

    static bool primo(int n)
    {
        if (divisores(n) > 2)
            return (false);
        else
            return (true);
    }
}
