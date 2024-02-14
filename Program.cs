using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite um numero n:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Total de divisores do numero {n}:\n {RetornaNDivPositivos(n)}");

      

       Console.WriteLine(VerificaSeEPrimo(n)); 

    }

    


    static bool VerificaSeEPrimo(int n)
    {
        if (RetornaNDivPositivos(n) == 2)
        {
            return true;
        }

        else
        {
            return false;
        }






    }





    static int RetornaNDivPositivos(int n)
    {
        int i, cont = 0;

        for (i = 1; i <= n; i++)
        {
            if (n % i == 0)
                cont++;
        }
        return (cont);
    }







}


