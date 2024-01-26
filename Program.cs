using System;

class Program
{
    static void Main()
    {
        int x, i = 0, p = 0;

        do
        {
            Console.WriteLine("Digite um número inteiro: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 1)
                i++;
            else
                p++;

        } while (p < i * 2);

        Console.WriteLine($"Quantidade de ímpares: {i}");
        Console.WriteLine($"Quantidade de pares: {p}");
    }
}
