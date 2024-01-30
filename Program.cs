using System;
using System.Diagnostics;
using System.Xml;

class Program
{
  static void Main()
  {
    int veiculos;
    float soma = 0, multas;
    float media;

    Console.WriteLine("Digite quantos veiculos sao: ");
    veiculos = int.Parse(Console.ReadLine());

    for (int i = 1; i <= veiculos; i++)
    {
      Console.WriteLine($"Digite o valor da multa do {i}o veiculo: ");
      multas = float.Parse(Console.ReadLine());

      soma += multas;

    }
    media = soma/veiculos;

    Console.WriteLine($"A soma das multas{soma}");
    Console.WriteLine($"A media das multas{media}");
    Console.WriteLine($"A quantidade de veiculos {veiculos}");










  }
}









