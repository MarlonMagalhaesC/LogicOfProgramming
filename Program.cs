using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {

        int n;
        float media, soma = 0, cont=0;

        Console.WriteLine("Digite um numero: ");
        n = int.Parse(Console.ReadLine());

        string[] Placas = new string[n];
        float[] Multas = new float[n];

        for (int i = 0; i < Placas.Length; i++)
        {
            Console.WriteLine($"Digite a placa do {i + 1}o veiculo: ");
            Placas[i] = Console.ReadLine();

            Console.WriteLine($"Digite a multa do {i + 1}o veiculo: ");
            Multas[i] = float.Parse(Console.ReadLine());

            if (Multas[i] > 0)
            {
                soma += Multas[i];
                cont++;
            }
        }

        media = soma / cont;
        Console.WriteLine($"media: {media} ");

        Console.WriteLine($"Possuem a multa superior a media: ");
        for (int i = 0; i < Multas.Length; i++)
        {
            if (Multas[i] > media)
            {
             Console.WriteLine($" Veiculo {i+1}, Placa: {Placas[i]}, {Multas[i]}");
            }
        }













    }
}
