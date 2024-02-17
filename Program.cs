using System.IO.Compression;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        Pergunta();
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

    static void Pergunta()

    {
        int a, b, c;

        Console.WriteLine("Digite a: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite b: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite c: ");
        c = int.Parse(Console.ReadLine());

        if (a < b)
            Console.WriteLine(ContaMultiplos(a, b, c));

        else 
        Console.WriteLine("Os valores de a e b não permitem realizar a tarefa.");



    }




}







