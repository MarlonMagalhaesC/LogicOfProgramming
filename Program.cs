using System;

class Program
{
    static void Main()
    {

        string[] Nomes = new string[3];
        float[] Notas = new float[3];
        int[] Frequencias = new int[3];
        string[] Situacao = new string[3];

        



        for (int i = 0; i < Nomes.Length; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1}o aluno: ");
            Nomes[i] = Console.ReadLine();

            Console.WriteLine($"Digite a nota do {i + 1}o aluno: ");
            Notas[i] = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a frequencia do {i + 1}o aluno: ");
            Frequencias[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < Nomes.Length; i++)
        {
            if (Notas[i] >= 60 && Frequencias[i] >= 75)
            {
                Console.WriteLine($"O aluno da posicao {i + 1}, {Nomes[i]} foi aprovado.");
                Situacao[i] = "Aprovado";
            }
            else
                Situacao[i] = "Reprovado";
        }



        Console.WriteLine("Situacao de cada aluno:");

        for (int i = 0; i < Nomes.Length; i++)
        {
            if (Situacao[i] == "Aprovado")
                Console.WriteLine($"A aluno {Nomes[i]} foi aprovado: ");

            else
                Console.WriteLine($"A aluno {Nomes[i]} foi reprovado: ");
        }















}
}
