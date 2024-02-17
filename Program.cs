using System.Net.Mail;

class Program
{
    static void Main()
    {
        int numero;

        numero = LeituraInteiro("Digite um número inteiro:");

        Console.WriteLine($"Número lido: {numero}");




    }

    static int LeituraInteiro(string mensagem)
    {
        int x;

        Console.WriteLine(mensagem);
        x = int.Parse(Console.ReadLine());

        return x;

    }





}







