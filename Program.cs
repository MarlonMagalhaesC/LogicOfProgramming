using System.IO.Compression;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite quantas pessoas serao: ");
        n = int.Parse(Console.ReadLine());

        mostraResultados(n);

    }

    static int TipoPessoa(int idade)
    {
        if (idade < 18)
            return 1;

        else
            return 2;
    }

    static void mostraResultados(int n)
    {
        float media;
        int somaMenor = 0, SomaMaior = 0, idades, somageral = 0;



        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Digite a idade da {i} pessoa:");
            idades = int.Parse(Console.ReadLine());

            somageral += idades;

            if (TipoPessoa(idades) == 1)

            {
                somaMenor++;
            }

            else
                SomaMaior++;
        }
        media = (float)somageral / n;


        Console.WriteLine("Media geral " +  media);
        Console.WriteLine("Total menores " +  somaMenor);
        Console.WriteLine("Total maiores " +  SomaMaior);



    }





}







