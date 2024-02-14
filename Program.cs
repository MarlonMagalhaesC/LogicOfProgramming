using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        float peso, altura;

        Console.WriteLine("Digite o peso:");
        peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura:");
        altura = float.Parse(Console.ReadLine());

        Console.WriteLine(IMC(peso, altura));
    }

    static double IMC(float peso, float altura)
    {
        double imc;

        imc = (double)peso / (altura * 2);

        return (imc);
    }







}


