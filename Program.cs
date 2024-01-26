using System;

class Program
{
    static void Main()
    {
        string nomecand1, nomecand2;
        int votoscand1, votoscand2;

        Console.WriteLine("Informe o nome do candidato 1:");
        nomecand1 = Console.ReadLine();

        Console.WriteLine("Informe o numero de votos do candidato 1:");
        votoscand1 = int.Parse(Console.ReadLine());  // Correção aqui

        Console.WriteLine("Informe o nome do candidato 2:");
        nomecand2 = Console.ReadLine();

        Console.WriteLine("Informe o numero de votos do candidato 2:");
        votoscand2 = int.Parse(Console.ReadLine());  // Correção aqui

        if (votoscand1 > votoscand2)
            Console.WriteLine($"O candidato {nomecand1} ganhou");

        else if (votoscand2 > votoscand1)
            Console.WriteLine($"O candidato {nomecand2} ganhou");

        else
            Console.WriteLine($"Uma nova eleição deve ser realizada, houve empate entre os candidatos");
    }
}
