using System.Net.Mail;

class Program
{
    static void Main()
    {
        
        Console.WriteLine(NDivisoresP(PerguntaN()));





    }

    static int PerguntaN()
    {
        int n;

        Console.WriteLine("Digite um numero para que seja n:");
        n = int.Parse(Console.ReadLine());

        return n;
    }

    static int NDivisoresP(int n)
    {

        if (n < 0)
        {
            return -1;
        }

        else if (n > 0)
        {
            int cont = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    cont++;
            }
            return cont;
        }

        else
        {
            return 0;
        }



    }
}







