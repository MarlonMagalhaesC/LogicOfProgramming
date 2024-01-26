using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        int n, numeros, conti = 0, contp = 0;

        Console.WriteLine("Digite a quantidade de numeros: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Digite o {i}o numero: ");
            numeros = int.Parse(Console.ReadLine());

            if (numeros % 2 == 0)
                contp++;

            else
                conti++;
        }

        Console.WriteLine($"A quantidade de numeros impares sao: {conti}");
        Console.WriteLine($"A quantidade de numeros pares sao: {contp}");


    }
}
