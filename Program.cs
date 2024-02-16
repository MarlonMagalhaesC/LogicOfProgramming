

class Program
{
    static void Main()
    {
        float a, b, c;
        double delta;


        Console.WriteLine("Digite a: ");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite b: ");
        b = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite c: ");
        c = float.Parse(Console.ReadLine());

        raizequacao(a,b,c);

    }

    static double CalculaDelta(float a, float b, float c)
    {
        double delta;

        delta = (double)Math.Pow(b, 2) - (4 * a * c);

        return delta;
    }

    static void raizequacao(float a, float b, float c)
    {
        double delta, x1, x2;

        delta = CalculaDelta(a, b, c);

        if (delta < 0)
            Console.WriteLine("Nao existe raiz real para essa equacao: ");


        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"X1 de {a}, {b}, {c}: {x1}");
            Console.WriteLine($"X2 de {a}, {b}, {c}: {x2}");
        }


    }



}


