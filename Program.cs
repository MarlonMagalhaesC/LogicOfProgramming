using System;

class Program
{
    static void Main()
    {
        int x, resultado, pontos = 0;

        Console.WriteLine("Digite a quantidade de jogos realizados pela equipe: ");
        x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            Console.Write($"Digite o resultado do {i}º jogo: (1 para vitória, 2 para derrota ou 3 para empate). ");
            resultado = int.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1:
                    pontos += 3;
                    break;
                case 2:
                    // Derrota não vale ponto
                    break;
                case 3:
                    pontos += 1;
                    break;
                default:
                    Console.WriteLine("Resultado inválido. Digite novamente.");
                    i--; 
                    break;
            }
        }

        Console.WriteLine($"Pontuação final da equipe: {pontos} pontos.");
    }
}
