

using System.Reflection;

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] V = new int[n];

        for (int i = 0; i<V.Length; i++)
        {
         Console.WriteLine($"Digite o elemento {i+1}o do Vetor: ");
         V[i] = int.Parse(Console.ReadLine());
        }

         Console.WriteLine(" Vetor: ");
          for (int i = 0; i<V.Length; i++)
        {
         Console.WriteLine(V[i]);
        
        }







    }
}
