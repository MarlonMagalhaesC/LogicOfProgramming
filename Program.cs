using System;
using System.Diagnostics;
using System.Xml;

class Program
{
  static void Main()
  {

    int n, x;
    float saldo, operacao;


    Console.WriteLine("Digite o sado inicial da conta: ");
    saldo = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite quantas operacoes foram feitas; ");
    n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine("Digite 1 para credito: ");
      Console.WriteLine("Digite 2 para debito ");
      x = int.Parse(Console.ReadLine());

      if (x == 1)
      {
        Console.WriteLine("Digite o valor da operacao: ");
        operacao = float.Parse(Console.ReadLine());

        saldo = saldo + operacao;
      }


      else if (x == 2)
      {
        Console.WriteLine("Digite o valor da operacao: ");
        operacao = float.Parse(Console.ReadLine());

        saldo = saldo - operacao;
      }


    }

Console.WriteLine(saldo);








  }
}









