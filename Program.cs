using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
      int n, i, soma=0, x;
      double media;

      Console.WriteLine("Digite a quantidade de alunos que voce quer calcuar a media: ");
      n = int.Parse(Console.ReadLine());

      for (i=1; i<=n; i++)
      {
        Console.WriteLine($"Digite a idade do {i}o aluno: ");
        x = int.Parse(Console.ReadLine());

        soma += x;

      }

      media = (double) soma / n;

   Console.WriteLine($"a media sera de {media}");


    }
}
