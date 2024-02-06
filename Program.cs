using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n, soma = 0, omaior = int.MinValue, omenor = int.MaxValue, pares = 0, impares = 0, positivos = 0, negativos = 0, nulos = 0;
        double media;


        Console.WriteLine("Digite 4 numeros: ");

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"Digite o {i}o numero: ");
            n = int.Parse(Console.ReadLine());

            soma += n;

            if (n > omaior)
                omaior = n;

            if (n < omenor)
                omenor = n;

            if (n % 2 == 0)
                pares++;

            else
                impares++;

            if (n > 0)
                positivos++;

            else if (n < 0)
                negativos++;

            else
                nulos++;

        }

        media = (double)soma / 4;

        Console.WriteLine($"A soma sera de: {soma}");
        Console.WriteLine($"A media sera de: {media}  ");
        Console.WriteLine($"o maior sera de: {omaior}");
        Console.WriteLine($"o menor sera de: {omenor}");
        Console.WriteLine($"pares sera de: {pares}");
        Console.WriteLine($"impares sera de: {impares}");
        Console.WriteLine($"positivos sera de: {positivos}");
        Console.WriteLine($"negativoa sera de: {negativos}");
        Console.WriteLine($"nulos sera de: {nulos}");






    }
}
