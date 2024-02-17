using System.IO.Compression;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        int a, b, c;

        Console.WriteLine("Digite a");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite b");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite c");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine(mostraResultados(a, b, c));

    }

    static float mostraResultados(int x, int y, int z)
    {
        int soma;
        float media = 0;

        soma = x + y + z;

        media = (float)soma / 3;
        return media;

    }



}







