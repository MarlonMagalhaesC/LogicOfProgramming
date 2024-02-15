using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main()
    {
        int x;

        Console.WriteLine("Digite o numero: ");
        x = int.Parse(Console.ReadLine());

        int[] Vetor = new int[x];

        for (int i = 0; i < Vetor.Length; i++)
        {
            Console.WriteLine($"Digite o {i + 1}o elemento: ");
            Vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(CalculaMedia(Vetor));



    }


    static float CalculaMedia(int[] Vetor)
    {
        float media;
        int soma = 0;

        for (int i = 0; i < Vetor.Length; i++)
        {
            soma += Vetor[i];
        }

        media = (float)soma / Vetor.Length;

        return (media);

    }

}


