using System;

class Program
{
    static void Main()
    {
        int x, y, z, n, R = 0;
        double media;

        Console.WriteLine("Digite n: ");
        n = int.Parse(Console.ReadLine());

           while (n > R)
        {
            Console.WriteLine("Digite x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite z: ");
            z = int.Parse(Console.ReadLine());

            media = (double)(x + z + y) / 3;


            Console.WriteLine($"A media e de {media} ");

            R++;

        }




    }
}
