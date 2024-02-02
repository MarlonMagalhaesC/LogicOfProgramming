using System;

class Program
{
    static void Main()
    {
        int x, y;
        double potencia = 1;

        Console.WriteLine("Digite um número (base): ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número (expoente): ");
        y = int.Parse(Console.ReadLine());

        for (int i = 1; i <= y; i++)
        {
            potencia *= x; // Multiplicação sucessiva para calcular x^y
        }

        Console.WriteLine($"Potência de {x} elevado a {y} é: {potencia}");
    }
}
