using System.Net.Mail;

class Program
{
    static void Main()
    {
        float saldoatual;
        int operacao;

        saldoatual = PerguntaSaldo();


        do
        {
            operacao = Opcoes();

            if (operacao == 1)
            {
                Console.WriteLine("Voce escolheu saque! ");
                saldoatual = OperacaoNegativa(saldoatual);
            }

            else if (operacao == 2)
            {
                {
                    Console.WriteLine("Voce escolheu deposito! ");
                    saldoatual = OperacaoPositiva(saldoatual);
                }
            }

            else if (operacao == 3)
            {
                Console.WriteLine("Voce escolheu Pagamento de conta! ");
                saldoatual = OperacaoNegativa(saldoatual);
            }

            else if (operacao == 4)
            {
                Console.WriteLine("Voce escolheu transferencia! ");
                saldoatual = OperacaoNegativa(saldoatual);
            }

            else if (operacao == 5)

                Console.WriteLine("Ate mais.");

            else

                Console.WriteLine("Digite um nome valido: ");

            Console.WriteLine($"Seu atual da conta: {saldoatual}");

        } while (operacao != 5);



    }

    static int Opcoes()
    {
        int operacao;

        Console.WriteLine("Digite a operacao: 1) Saque \n 2) Depósito \n 3) Pagamento de Conta \n 4) Transferência \n 5) Sair ");
        operacao = int.Parse(Console.ReadLine());

        return operacao;
    }

    static float PerguntaSaldo()
    {
        float saldoatual;

        Console.WriteLine("Digite o saldo atual da conta:");
        saldoatual = float.Parse(Console.ReadLine());

        return saldoatual;
    }

    static float OperacaoNegativa(float saldoatual)
    {
        float valoroperacao;

        Console.WriteLine("Digite o valor da operacao:");
        valoroperacao = float.Parse(Console.ReadLine());

        saldoatual -= valoroperacao;

        return saldoatual;
    }

    static float OperacaoPositiva(float saldoatual)
    {
        float valoroperacao;

        Console.WriteLine("Digite o valor da operacao:");
        valoroperacao = float.Parse(Console.ReadLine());

        saldoatual += valoroperacao;

        return saldoatual;

    }


}







