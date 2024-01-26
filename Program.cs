using System;

class Program
{
    static void Main()
    {
        int x, p = 0, i = 0;

        do
        {
            Console.WriteLine("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
                p++;

            else
                i++;


        } while (p < 5 && i < 5);

        Console.WriteLine($"Contagem numeros pares {p}");
        Console.WriteLine($"Contagem numeros impares {i}");



    }
}
