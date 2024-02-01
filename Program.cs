using System;

class Program
{
    static void Main()
    {
        int x, y;

        Console.WriteLine("Digite um numero ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero ");
        y = int.Parse(Console.ReadLine());

       int diferenca = (x*y)-(x+y);
       int resultado = x+y;

        for (int i=1; i<=diferenca; i++)
        {
          resultado++;
        }

        Console.WriteLine($"{x * y}, {resultado}");
    }
}
