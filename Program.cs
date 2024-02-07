using System;
using System.Runtime.CompilerServices;


class Program
{
    static void Main()
    {
        int idade, flag = 0, i = 1, naoeleitor = 0, eobrigatorio = 0, efacultativo = 0;

        while (flag != 1)
        {
            Console.WriteLine($"Digite a idade da {i}o pessoa: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 15)
            {
                Console.WriteLine($"Status {i}o pessoa: não eleitor");
                naoeleitor++;
            }

            else if (idade >= 18 && idade < 71)
            {
                Console.WriteLine($"Status {i}o pessoa: eleitor obrigatorio");
                eobrigatorio++;
            }

            else if (idade > 15 && idade < 18 || idade > 70)
            {
                Console.WriteLine($"Status {i}o pessoa: eleitor facultativo");
                efacultativo++;
            }

            else
                flag++;

            i++;
        }


        Console.WriteLine($"Total nao eleitores: {naoeleitor}");
        Console.WriteLine($"Total eleitor obrigatorio: {eobrigatorio}");
        Console.WriteLine($"Total eleitor facultativo: {efacultativo}");













    }
}
