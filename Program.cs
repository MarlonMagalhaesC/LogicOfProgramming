

class Program
{
    static void Main()
    {
        int q1, q2, cont = 0;

        Console.WriteLine("Digite um numero: ");
        q1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero: ");
        q2 = int.Parse(Console.ReadLine());

        int[] V1 = new int[q1];

        int[] V2 = new int[q2];

        for (int i = 0; i < V1.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento do vetor 1: ");
            V1[i] = int.Parse(Console.ReadLine());

            for (int j=0; j<i; j++)
            {
              if (V1[i] == V1[j])
              {
                Console.WriteLine("Nao e permitido a repeticao de numeros: ");
                i--;
              }

            }
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
                if (V1[i] == V2[j])
                    cont++;
            }

              Console.WriteLine($" {V1[i]} presente {cont}vezes");
              cont=0;

        }

       

    }
}
