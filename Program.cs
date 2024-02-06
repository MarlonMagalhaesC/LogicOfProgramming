using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n, idade, i = 0, soma = 0;
        double media;

        Console.WriteLine("Calcule a media da turma");

        do
        {
            i++;
            Console.WriteLine($"Digite a idade da {i}o pessoa: ");
            idade = int.Parse(Console.ReadLine());

            if (idade > 0)
            {
               soma += idade;
            }

        } while (idade != 0);


        media = (double)soma / i;

        Console.WriteLine($"A media sera de: {media} ");




    }
}
