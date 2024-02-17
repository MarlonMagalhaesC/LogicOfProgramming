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

        Console.WriteLine(validaValores(a, b, c));

    }

    static bool validaValores(int x, int y, int z)
    {
        return (x + y + z) % x == 0;
    }




}







