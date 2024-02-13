using System;

class Program
{
    static void Main()
    {

        float[] Pesos = new float[4];
        float media, soma = 0;


        for (int i = 0; i < Pesos.Length; i++)
        {
            Console.WriteLine($"Digite o peso da {i + 1}o pessoa: ");
            Pesos[i] = float.Parse(Console.ReadLine());

            soma += Pesos[i];
        }

        media = soma / Pesos.Length;

           for (int i = 0; i < Pesos.Length; i++)
        {
            if(Pesos[i] < media)
            Console.WriteLine(Pesos[i]);
            
        }



















    }
}
