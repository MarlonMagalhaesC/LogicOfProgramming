using System;

class Program
{
  static void Main()
  {
    int n;

    Console.WriteLine("Digite o numero de eleitores: ");
    n = int.Parse(Console.ReadLine());

    if (n < 10)
      Console.WriteLine($"{n} e menor que 10, digite novamente. ");



    else
    {
      int voto, Teobaldo = 0, Astrogildo = 0, branco = 0, nulo = 0;

      Console.WriteLine($"Tabela de votacao. \n 1- Teobaldo \n 2- Astrogildo \n 0- Branco \n Nulo- Demais numeros.  ");

      for (int i = 1; i <= n; i++)
      {
        voto = 0;

        Console.WriteLine($"{i}o Eleitor, digite o numero do seu voto. ");
        voto = int.Parse(Console.ReadLine());

        if (voto == 1)
          Teobaldo++;

        else if (voto == 2)
          Astrogildo++;

        else if (voto == 0)
          branco++;

        else
          nulo++;


      }

      Console.WriteLine($"O candidato Telbado teve um total de {Teobaldo} votos. ");
      Console.WriteLine($"O candidato Astrogildo teve um total de {Astrogildo} votos. ");
      Console.WriteLine($"Votos em branco: {branco} ");
      Console.WriteLine($"Votos nulos {nulo} ");










    }
  }
}









