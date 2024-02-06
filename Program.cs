using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int pares = 0, impares = 0, i = 0, n = 0;


        while (n != -1)
        {

            i++;

            Console.WriteLine($"Digite o {i}o numero inteiro positivo: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                pares++;

            else
                impares++;

        }

        Console.WriteLine(pares);
        Console.WriteLine(impares - 1);



    }
}
