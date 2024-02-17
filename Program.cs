using System.IO.Compression;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        int n1, n2, n3;

        do
        {
            Console.WriteLine("Digite n1");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite n2");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite n3");
            n3 = int.Parse(Console.ReadLine());


        } while (validaValores(n1, n2, n3) == false);

        mostraResultados(n1, n2, n3);


    }

    static void mostraResultados(int x, int y, int z)
    {
        int soma;
        float media = 0;

        soma = x + y + z;
        Console.WriteLine("soma" + soma);
        media = (float)soma / 3;

        Console.WriteLine("media" + media);
    }

    static bool validaValores(int x, int y, int z)
    {
        return (x + y + z) % x == 0;

    }
}






