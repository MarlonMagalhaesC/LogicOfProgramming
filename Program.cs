using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n;
        double x;


        Console.WriteLine("Digite um numero: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
        {
           x = Math.Pow(2,i);
            if (x < n)
            Console.WriteLine($"{x} e menor que {n}. ");

           

        }





    }
}
