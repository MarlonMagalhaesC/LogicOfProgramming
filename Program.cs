using System.IO.Compression;
using System.Net.Mail;

class Program
{
    static void Main()
    {
       int idade;

       Console.WriteLine("Digite sua idade: ");
       idade = int.Parse(Console.ReadLine());

       Console.WriteLine(TipoPessoa(idade));
    }

    static int TipoPessoa(int idade)
    {
     if (idade < 18)
     return 1;

     else
     return 2;
    }





}







