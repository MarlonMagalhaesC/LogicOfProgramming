

class Program
{
    static void Main()
    {
        int i, soma = 0;
        float media;

        int[] V = new int[10];

        for (i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i + 1} numero");
            V[i] = int.Parse(Console.ReadLine());
            soma += V[i];
        }

        media = (float)soma / 10;
        
        for (i = 0; i < V.Length; i++)
        {
           if (V[i] > media){
           Console.WriteLine($"o {i + 1}o elemeento, {V[i]} e maior que a media.");
           }
        }


    }
}
