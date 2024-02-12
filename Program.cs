

class Program
{
    static void Main()
    {
        int i, contp = 0, conti = 0, indexp = 0, indexi = 0, somap = 0, somai = 0;
        float mediap, mediai;

        int[] V = new int[10];

        for (i = 0; i < V.Length; i++)
        {
            Console.WriteLine($"Digite o {i+1}o elemento do Vetor: ");
            V[i] = int.Parse(Console.ReadLine());

            if (V[i] % 2 == 0)
                contp++;

            else
                conti++;
        }

        int[] VP = new int[contp];
        int[] VI = new int[conti];

        for (i = 0; i < V.Length; i++)
        {
            if (V[i] % 2 == 0)
            {
                VP[indexp] = V[i];
                indexp++;
                somap += V[i];
            }
            else
            {
                VI[indexi] = V[i];
                indexi++;
                somai += V[i];
            }
        }
        Console.WriteLine($"VP");
        for (i = 0; i < VP.Length; i++)
        {
            Console.WriteLine(VP[i]);
        }

        Console.WriteLine($"VI");
        for (i = 0; i < VI.Length; i++)
        {
            Console.WriteLine(VI[i]);
        }

        mediap = (float)somap / VP.Length;
        mediai = (float)somai / VI.Length;

        Console.WriteLine($"A soma do Vetor de pares sera {somap} e a media {mediap}");
        Console.WriteLine($"A soma do Vetor de impares sera {somai} e a media {mediai}");



    }
}
