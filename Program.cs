

class Program
{
    static void Main()
    {
        int n, cont = 0;



        do
        {
            Console.WriteLine("Digite o número de dezenas que uma determinada pessoa apostou na MegaSena, (entre 6-15): ");
            n = int.Parse(Console.ReadLine());


        } while (n < 6 || n > 15);



        int[] VA = new int[n];
        int[] VS = new int[6];

        for (int i = 0; i < VA.Length; i++)
        {
            Console.WriteLine($"Digite a {i + 1}o dezena que a pessoa apostou: (entre 1 e 60) ");
            VA[i] = int.Parse(Console.ReadLine());
            if (VA[i] < 1 || VA[i] > 60)
            {
                Console.WriteLine("(entre 1 e 60)");
                i--;
            }
        }

        for (int i = 0; i < VS.Length; i++)
        {
            Console.WriteLine($"Digite a {i + 1}o dezena que foi sorteada: ");
            VS[i] = int.Parse(Console.ReadLine());
            if (VS[i] < 1 || VS[i] > 60)
            {
                Console.WriteLine("(entre 1 e 60)");
                i--;
            }
        }

        Console.WriteLine("Vetor que a pessoa apostou: ");
        for (int i = 0; i < VA.Length; i++)
        {
            Console.WriteLine(VA[i]);
        }

        Console.WriteLine("Vetor que foi sorteado: ");

        for (int i = 0; i < VS.Length; i++)
        {
            Console.WriteLine(VS[i]);
        }

        for (int i = 0; i < VA.Length; i++)
        {
            for (int j = 0; j < VS.Length; j++)
            {
                if (VA[i] == VS[j])
                {
                    cont++;
                    break;
                }
            }
        }

        Console.WriteLine($"A pessoa acertou {cont}dezenas: ");






    }
}
