using System;

class Program
{
    static void Main()
    {
        int x, fatorial=1;

        Console.WriteLine("Digite um número: ");
        x = int.Parse(Console.ReadLine());

       
        for (int i = 1; i <= x; i++)
        {
            fatorial *= i;
            
        }

        Console.WriteLine(fatorial);
    }
}
