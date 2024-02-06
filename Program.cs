using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int n, cont=0;

        Console.WriteLine("Digite um numero inteiro: ");
        n = int.Parse(Console.ReadLine());

         for (int i=1; i<=n; i++)
         {
            if (n % i == 0)
            cont++;
       

         }

         if (cont != 2)
         Console.WriteLine($"{n} nao e primo");

         else 
         Console.WriteLine($"{n}e primo");


    }
}
