using System;

class Program
{
    static void Main()
    {
        int x, y, z;
        double media;


        do
        {
            Console.WriteLine("Digite x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite z: ");
            z = int.Parse(Console.ReadLine());

            media = (double)(x + z + y) / 3;

            if (media <30)
            Console.WriteLine("A media nao pode ser menor que 30. ");

            else 
            Console.WriteLine($"A media e de {media} ");

        } while (media < 30);




    }
}
