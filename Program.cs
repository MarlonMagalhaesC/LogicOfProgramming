using System;
using System.Diagnostics;
using System.Xml;

class Program
{
  static void Main()
  {

    int n, soma = 0, numeros, menor= int.MaxValue, maior=int.MinValue, pares = 0, impares = 0, positivos = 0, negativos = 0, nulos = 0;
    float media;

    Console.WriteLine("Digite um numero inteiro positivo: ");
    n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine($"Digite o {i}o numero: ");
      numeros = int.Parse(Console.ReadLine());

      soma += numeros;

      if (numeros > maior)
        maior = numeros;

      if (numeros < menor)
        menor = numeros;

      if (numeros % 2 == 0)
        pares++;

      else
        impares++;

      if (numeros > 0)
        positivos++;

      else if (numeros < 0)
        negativos++;

      else
        nulos++;

    }

    media = (float) soma / n;

Console.WriteLine($"Soma {soma}");
Console.WriteLine($"Media {media}");
Console.WriteLine($"O maior{maior}");
Console.WriteLine($"O menor {menor}");
Console.WriteLine($"Pares {pares}");
Console.WriteLine($"Impares {impares}");
Console.WriteLine($"Positivos {positivos}");
Console.WriteLine($"Negativos {negativos}");
Console.WriteLine($"Nulos {nulos}");






  }
}









