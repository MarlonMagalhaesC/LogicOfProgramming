using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
  static void Main()
  {
    int q1, q2;

    Console.WriteLine("Digite um numero inteiro positivo: ");
    q1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um numero inteiro positivo: ");
    q2 = int.Parse(Console.ReadLine());

    for (int i = 1; i <= q1; i++)
    {
      for (int j = 1; j <= q2; j++)
      {
        Console.WriteLine($"{i},{j}");
      }
    }





  }
}
