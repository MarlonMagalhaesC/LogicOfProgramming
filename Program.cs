

class Program
{
    static void Main()
    {
        double a, b;

        Console.WriteLine("Digite o numero: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o numero: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Hipotenusa: {CalculaHipotenusa(a, b)} ");



    }

    static double CalculaHipotenusa(double a, double b)
    {
        double c;

        c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        return c;

    }



}


