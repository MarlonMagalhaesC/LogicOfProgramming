

class Program
{
    static void Main()
    {
        float a, b, c;

        Console.WriteLine("Digite a: ");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite b: ");
        b = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite c: ");
        c = float.Parse(Console.ReadLine());

        Console.WriteLine(CalculaDelta(a,b,c));



    }

    static double CalculaDelta(float a, float b, float c)
    {
        double delta, x1, x2;

        delta = (double)Math.Pow(b, 2) - (4 * a * c);

        x1 = (-b + Math.Sqrt(delta)) / (2 * a);

        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (x1 > 0)
            return x1;

        else
            return x2;

    }



}


