using System.Net.Mail;

class Program
{
    static void Main()
    {
        int x,y,z;

        Console.WriteLine("Digite x: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite y: ");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite z: ");
        z = int.Parse(Console.ReadLine());

        Console.WriteLine(ContaMultiplos(x,y,z));

    }

    static int ContaMultiplos(int x, int y, int z)
    {
        int i, cont = 0;

        for (i = x; i <= y; i++)
        {
            if (z % i == 0)
                cont++;
        }

        return cont;
    }







}







