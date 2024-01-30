using System;
using System.Diagnostics;
using System.Xml;

class Program
{
  static void Main()
  {
    int n, x, par=0, impar=0;

    Console.WriteLine("Digite quantos numeros voce quer que seja: ");
    n = int.Parse(Console.ReadLine());

    for (int i=1; i<=n; i++)
    {
     Console.WriteLine($"Digite o {i}o elemento: ");
     x = int.Parse(Console.ReadLine());

     if (x % 2 == 0)
     par++;

     else
     impar++;   


    }

    Console.WriteLine($"Total de pares: {par} ");
    Console.WriteLine($"Total de impar: {impar} ");









  }
}









