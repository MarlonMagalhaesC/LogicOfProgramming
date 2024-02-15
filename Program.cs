using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int x, y, z;

        Console.WriteLine("Digite o primeiro numero: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro numero: ");
        z = int.Parse(Console.ReadLine());


        Console.WriteLine(CalculaMedia(x,y,z));
    }


    static float CalculaMedia(int x, int y, int z)
    {
        float media;

        media = (float)(x + y + z) / 3;

        return (media);
    }

}


