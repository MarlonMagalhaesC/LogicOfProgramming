using System;

class Program
{
    static void Main()
    {
        int x, y, produto, adicao;

        Console.WriteLine("Digite um numero ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero ");
        y = int.Parse(Console.ReadLine());

        produto = x * y;
        adicao = x + y;

        // Correção no loop while
        while (produto != adicao)
        {
            adicao = adicao + 1;
        }

        Console.WriteLine($"{x * y}, {adicao}");
    }
}
