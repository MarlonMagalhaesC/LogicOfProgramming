

class Program
{
    static void Main()
    {
        int n, cont = 0;

        Console.WriteLine("Digite o número de dezenas que uma determinada pessoa apostou na MegaSena: ");
        n = int.Parse(Console.ReadLine());

        int[] VA = new int[n];
        int[] VS = new int[6];

        for (int i = 0; i < VA.Length; i++)
        {
            Console.WriteLine($"Digite a {i + 1}o dezena que a pessoa apostou: ");
            VA[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < VS.Length; i++)
        {
            Console.WriteLine($"Digite a {i + 1}o dezena que foi sorteada: ");
            VS[i] = int.Parse(Console.ReadLine());
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
