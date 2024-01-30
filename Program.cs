using System;
using System.Xml;

class Program
{
  static void Main()
  {
    int n, idade, soma=0;
    double media;

    Console.WriteLine("Digite um numero de n pessoas: ");
    n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
     Console.WriteLine($"Digite a idade da {i}o pessoa: ");
     idade = int.Parse(Console.ReadLine());

     soma += idade;

    }

    media = (double)soma/n;
 
Console.WriteLine($"A media sera de {media}");









  }
}









