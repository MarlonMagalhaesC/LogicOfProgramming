using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int i = 1, numeros, soma = 0, flag = 0;
        float media;



        while (flag != -1)
        {
            Console.Write($"Digite o {i}o numero:");
            numeros = int.Parse(Console.ReadLine());

            if (numeros >= 0)
            {
                soma += numeros;
                i++;
            }

            else
                flag--;

        }

        media = (float)soma / (i - 1);

        Console.WriteLine($"A soma sera de: {soma}");
        Console.WriteLine($"A media sera de: {media}");




    }
}
