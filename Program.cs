using System;

class Program
{
    static void Main()
    {
        int x, y, z, n;
        double media;

        do
        {
            Console.WriteLine("Digite n: ");
            n = int.Parse(Console.ReadLine());

            if (n < 5)
                Console.WriteLine("O n nao pode ser menor que 5. ");
        } while (n < 5);


        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Digite x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite z: ");
            z = int.Parse(Console.ReadLine());

            media = (double)(x + z + y) / 3;


            Console.WriteLine($"A media e de {media} ");


        }


    }
}
